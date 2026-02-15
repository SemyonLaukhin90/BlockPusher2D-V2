using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class playerMove : MonoBehaviour
{
    
    
        public float moveSpeed = 15f;
        private Rigidbody2D rb;
        private Vector2 moveInput;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            moveInput.x = Input.GetAxisRaw("Horizontal");
            moveInput.y = Input.GetAxisRaw("Vertical");
        }

        void FixedUpdate()
        {
            rb.linearVelocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
        }
}
