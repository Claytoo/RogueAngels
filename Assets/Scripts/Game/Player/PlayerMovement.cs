using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController playerControl;

    Vector2 moveDirection;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        moveDirection = new Vector2(x, y);
        moveDirection = moveDirection.normalized;
    }

    private void FixedUpdate()
    {
        playerControl.rigidBody.velocity = moveDirection * playerControl.moveSpeed;
    }
}
