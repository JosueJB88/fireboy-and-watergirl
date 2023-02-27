using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    private float horizontal;
    private float speed = 1000f;
    private float jumpingPower = 500f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    public int jumpCount = 0;
    public int maxJumpCount = 2;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        Debug.Log(groundLayer.value);

        // if (Input.GetButtonDown("Jump") && IsGrounded())
        // {
        //     rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        // }

        // if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        // {
        //     rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        // }

        if (Input.GetButtonDown("Jump") && (IsGrounded() || jumpCount < maxJumpCount))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            jumpCount++;
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        if (!IsGrounded())
        {
            jumpCount = Mathf.Clamp(jumpCount, 0, maxJumpCount);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
