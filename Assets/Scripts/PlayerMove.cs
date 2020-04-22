using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float movementSpeed;

    private CharacterController charController;

    [SerializeField] private AnimationCurve jumpFallOff;
    [SerializeField] private float jumpMultiplier;
    [SerializeField] private KeyCode jumpKey;

    private Vector3 originalPosition;
    private Quaternion originalRotation;

    [SerializeField] private AudioSource startTheme;
    [SerializeField] private AudioSource firstLevelTheme;
    [SerializeField] private AudioSource DungeonAmbience;

    private string currentTheme;

    private bool isJumping;

    [SerializeField] private AudioSource JumpSound;
    [SerializeField] private AudioSource DieSound;



    private void Awake()
    {
        currentTheme = "start";
        charController = GetComponent<CharacterController>();
    }

    public void resetTransform()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
    }

    private void Update()
    {
        if (transform.position.z > -26f && currentTheme == "start"){
            originalPosition = transform.position;
            originalRotation = transform.rotation;
            currentTheme = "first";
            startTheme.Stop();
            firstLevelTheme.Play();
            DungeonAmbience.Play();
        }
        else if (transform.position.z > 39f && currentTheme == "first"){
            originalPosition = transform.position;
            originalRotation = transform.rotation;
            currentTheme = "second";
        }

        PlayerMovement();
    }

    private void LateUpdate() {
        if (transform.position.y < 2f)
        {
          DieSound.Play();
          resetTransform();
        }
    }

    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.SimpleMove(forwardMovement + rightMovement);

        JumpInput();
    }

    private void JumpInput()
    {
        if(Input.GetKeyDown(jumpKey) && !isJumping)
        {
            JumpSound.Play();
            isJumping = true;
            StartCoroutine(JumpEvent());
        }
    }

    private IEnumerator JumpEvent()
    {
        charController.slopeLimit = 90.0f;
        float timeInAir = 0.0f;

        do
        {
            float jumpForce = jumpFallOff.Evaluate(timeInAir);
            charController.Move(Vector3.up * jumpForce * jumpMultiplier * Time.deltaTime);
            timeInAir += Time.deltaTime;
            yield return null;
        } while (!charController.isGrounded && charController.collisionFlags != CollisionFlags.Above);

        charController.slopeLimit = 45.0f;
        isJumping = false;
    }
}
