using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController playerControl;

    private Animator anim;

    private Vector2 moveInput;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        playerControl.rigidBody.velocity = moveInput.normalized * playerControl.moveSpeed;

        if (moveInput != Vector2.zero)
        {
            anim.SetBool("isMoving", true);
        }

        else
        {
            anim.SetBool("isMoving", false);
        }
    }
}
