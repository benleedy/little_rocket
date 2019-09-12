using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{

    Rigidbody rigidBody;
    AudioSource audioSource;

    enum State { Alive, Dying, Transcending }
    State state = State.Alive;
    bool ignoreCollisions = false;
    int currentSceneIndex;

    [SerializeField] float rcsThrust = 100f;
    [SerializeField] float engineThrust = 1f;
    [SerializeField] float levelLoadDelay = 2f;

    [SerializeField] AudioClip mainEngine;
    [SerializeField] AudioClip death;
    [SerializeField] AudioClip success;

    [SerializeField] ParticleSystem mainEngineParticles;
    [SerializeField] ParticleSystem deathParticles;
    [SerializeField] ParticleSystem successParticles;

    //[SerializeField] float MaxVelocity = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.Alive)
        {
            RespondToRotateInput();
            RespondToThrustInput();
        }
        if (Debug.isDebugBuild)
        {

            DebugOptions();
        }

        //If I want a speed limit, this is how I would implement it.
        /*
        rigidBody.velocity = Vector3.ClampMagnitude(rigidBody.velocity, MaxVelocity);
        print(rigidBody.velocity);
        */
    }

    void OnCollisionEnter(Collision collision)
    {
        if (state != State.Alive){return;} //guard condition

        if (ignoreCollisions == false)
        {
            switch (collision.gameObject.tag)
            {
                case "Friendly":
                    //do nothing
                    break;
                case "Finish":
                    StartSuccessSequence();
                    StabilizeRocket(collision.gameObject.transform);
                    break;
                case "Checkpoint":
                    //stand the rocket upright
                    StabilizeRocket(collision.gameObject.transform);
                    break;
                default:
                    StartDeathSequence();
                    break;
            }
        }

    }

    
    void StabilizeRocket(Transform pad)
    {
        rigidBody.freezeRotation = true;  // take manual control of rotation
        //transform.SetPositionAndRotation(new Vector3(pad.transform.position.x, (pad.transform.position.y + 3.65), pad.transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
        transform.SetPositionAndRotation(new Vector3(pad.transform.position.x, (pad.transform.position.y + 1.65f), pad.transform.position.z), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
        rigidBody.freezeRotation = false;  // take manual control of rotation
        rigidBody.velocity = new Vector3(0f,0f,0f);
    }

    private void StartSuccessSequence()
    {
        state = State.Transcending;
        audioSource.Stop();
        audioSource.PlayOneShot(success);
        successParticles.Play();
        Invoke("LoadNextLevel", levelLoadDelay);
    }

    private void StartDeathSequence()
    {
        state = State.Dying;
        mainEngineParticles.Stop();
        audioSource.Stop();
        audioSource.PlayOneShot(death);
        deathParticles.Play();
        Invoke("LoadFirstLevel", levelLoadDelay);
    }

    private void LoadNextLevel()
    {
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

    private void LoadFirstLevel()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }

    void RespondToThrustInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ApplyThrust();
        }
        else if (Input.GetKey(KeyCode.W))
        {
            ApplyThrust();
        }
        else if (Input.GetKey(KeyCode.U))
        {
            //StabilizeRocket();
        }
        else
        {
            audioSource.Stop();
            mainEngineParticles.Stop();
        }
    }

    private void ApplyThrust()
    {
        rigidBody.AddRelativeForce(Vector3.up * engineThrust * Time.deltaTime);
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(mainEngine);
        }
        mainEngineParticles.Play();
    }

    private void RespondToRotateInput()
    {
        


        float rotationThisFrame = rcsThrust * Time.deltaTime;
            
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.freezeRotation = true;  // take manual control of rotation
            transform.Rotate(Vector3.forward * rotationThisFrame);
            rigidBody.freezeRotation = false; // resume physics control of rotation
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidBody.freezeRotation = true;  // take manual control of rotation
            transform.Rotate(-Vector3.forward * rotationThisFrame);
            rigidBody.freezeRotation = false; // resume physics control of rotation
        }

    }

    private void DebugOptions()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadNextLevel();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ignoreCollisions = !ignoreCollisions;
        }
    }
}
