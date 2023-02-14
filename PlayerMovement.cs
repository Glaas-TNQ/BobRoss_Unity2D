using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 200f;
    private Rigidbody2D rb;

   
    public Vector2 movementDirection;
    public float horizontal;
    public float vertical;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Vector2 movementDirection = new Vector2(horizontal, vertical);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();
        transform.Translate(movementDirection * moveSpeed * 1 * Time.deltaTime, Space.World);
        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotateSpeed * Time.deltaTime);
            Vector3 direction = new Vector3(movementDirection.x, movementDirection.y, 0f);
            Debug.DrawLine(transform.position, transform.position + direction * 2f, Color.red);
        }
        

       
    }


}
