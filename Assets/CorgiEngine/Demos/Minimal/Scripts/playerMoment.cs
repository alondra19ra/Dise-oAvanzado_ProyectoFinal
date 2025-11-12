using UnityEngine;

public class playerMoment : MonoBehaviour
{
    public float speed = 1.0f;
    public float forceJump = 1.0f;
    private float x;
    private bool Jump;
    private Vector2 direction;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jump = false;
        }
    }
    private void FixedUpdate()
    {
        direction = new Vector2(x * speed, rb.linearVelocity.y);
        rb.linearVelocity = direction;
        if (Jump)
        {
            rb.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
            Debug.Log("Se llama al metodo");
        }
    }
}
