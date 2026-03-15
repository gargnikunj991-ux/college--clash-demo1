
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    public static bool inputEnabled = true;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!inputEnabled) return;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (!inputEnabled) return;

        rb.linearVelocity = movement.normalized * speed;
    }
}