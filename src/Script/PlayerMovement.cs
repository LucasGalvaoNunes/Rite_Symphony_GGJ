using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float VelocidadeRot = 2.0f;
    public float VelocidadeRotTras = 20.0f;
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public Animator anim;
    private Vector3 moveDirection = Vector3.zero;
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;


        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -VelocidadeRot, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, VelocidadeRot, 0);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, VelocidadeRotTras, 0);
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }


}

