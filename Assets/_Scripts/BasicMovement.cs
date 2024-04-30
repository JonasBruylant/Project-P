using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    private Vector2 _movementDirection = new();
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void ProcessInput()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        _movementDirection = new Vector2(horizontalInput, verticalInput).normalized;   
    }

    private void Move()
    {
        _rb.velocity = new Vector2(_movementDirection.x * movementSpeed, _movementDirection.y * movementSpeed);   
    }
}
