using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController characterController;

    private float xMovement;
    private float zMovement;

    public float speed = 8f;
    public float gravity;
    public float checkerRadious;
    public float jumpForce;

    private bool isGrounded;

    public Transform grounChecker;

    public LayerMask groundMask;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        isGrounded = Physics.CheckSphere(grounChecker.position, checkerRadious, groundMask);

        if(isGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }

        xMovement = Input.GetAxis("Horizontal");
        zMovement = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xMovement + transform.forward * zMovement;

        characterController.Move(move*speed*Time.deltaTime);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space)){
            velocity.y = Mathf.Sqrt(jumpForce * -2 * gravity);
        }

        velocity.y += gravity * 1.5f * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }

}
