using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed;
    private Vector3 direction;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void MovePlayer(Vector3 direction, float speed)
    {
        this.direction = direction;
        this.speed = speed;
    }

    public void JumpPlayer(float jumpForce)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        if (direction != Vector3.zero)
        {
            rb.velocity = direction * speed + new Vector3(0, rb.velocity.y, 0);
        }
        else
        {
            // nếu không có input, thì dừng lại
            rb.velocity = Vector3.zero + new Vector3(0, rb.velocity.y, 0);
        }
    }
}
