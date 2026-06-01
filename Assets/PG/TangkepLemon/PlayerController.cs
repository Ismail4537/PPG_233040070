using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] GroundDetect groundDetect;
    // [SerializeField] int health = 100;
    [SerializeField] float speed = 5;
    [SerializeField] float jumpForce = 5;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        groundDetect = GetComponentInChildren<GroundDetect>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();
    }

    void Movement()
    {
        float xInput = Input.GetAxis("Horizontal");
        if (xInput != 0)
        {
            rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && groundDetect.isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnMouseEnter()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;
    }

    void OnMouseExit()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = Color.white;
    }

    void OnMouseDrag()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = Color.blue;
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
        rb.velocity = Vector2.zero;
    }
}
