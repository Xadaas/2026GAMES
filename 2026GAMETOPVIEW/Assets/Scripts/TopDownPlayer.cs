using UnityEngine;
using UnityEngine.InputSystem;
public class TopDownPlayer : MonoBehaviour
{
    public float moveSpeed = 4f;
    private Vector2 moveInput;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;

    }
}
