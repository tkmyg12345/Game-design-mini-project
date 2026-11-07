using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpForce;

    private float horizontalInput;
    private Animator playerAnim;
    [Header("Grounding")]
    public Transform GroundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius;
    private Rigidbody2D rb; 
    
    private int flippingDirection = 1;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAnim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if(horizontalInput > 0.1f && flippingDirection < 0 || horizontalInput < 0.1f && flippingDirection > 0)
        {
            Flip();
        }

        //Movement Anim
        if (horizontalInput != 0 ) playerAnim.SetInteger("Speed", 1);
        else playerAnim.SetInteger("Speed", 0);

        //Jumping
        if(Input.GetButtonDown("Jump") && IsGrounded())
         rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * speed, rb.linearVelocity.y);
        
    }

    bool IsGrounded()
    {


        return  Physics2D.OverlapCircle(GroundCheck.position, groundCheckRadius, groundLayer );
    }


    void Flip()
    {
        flippingDirection *= -1;

        Vector3 scale = transform.localScale;
        scale.x *= -1;

        transform.localScale = scale;


    }
}
