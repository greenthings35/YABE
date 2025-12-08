using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Vector2 movement;
    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movement.Set(inputManager.Movement.x, inputManager.Movement.y);
        rb.linearVelocity = movement * moveSpeed;
    }

}
