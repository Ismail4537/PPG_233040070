using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    Rigidbody2D rb;
    public float MaxSpeed = 10f;
    public float scalling = 2f;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        // Move towards mouse position on the x-axis with it speed depending on the distance
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = rb.position.y;
        Vector2 direction = (mousePos - rb.position).normalized;
        if (Vector2.Distance(rb.position, mousePos) < 0.1f)
        {
            rb.velocity = Vector2.zero;
            return;
        }
        float distance = Vector2.Distance(rb.position, mousePos);
        float speed = Mathf.Clamp01(distance / scalling) * MaxSpeed;
        rb.velocity = direction * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lemon"))
        {
            Destroy(collision.gameObject, 0.5f);
        }
    }
}
