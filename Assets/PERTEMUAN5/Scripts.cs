using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 5f;
    public float rotateForce = 5f;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector2(3, 3);
        transform.position = new Vector2(-3, 3);
        // transform.position = new Vector2(3, -3);
        // transform.position = new Vector2(-3, -3);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude < 0.1f && groundCheck())
        {
            Invoke("jump", 0.1f);
            Invoke("XDir", 0.1f);
        }
        rotate();
    }

    void jump()
    {
        rb.AddForce(new Vector2(0, jumpForce * transform.localScale.x), ForceMode2D.Impulse);
        scaleChange();
    }

    void XDir()
    {
        int rand = Random.Range(-1, 2);
        print(rand);
        rb.AddForce(new Vector2(jumpForce * rand * transform.localScale.x, 0), ForceMode2D.Force);
    }

    bool groundCheck()
    {
        RaycastHit2D[] collide = Physics2D.RaycastAll(transform.position, Vector2.down, 1f * transform.localScale.x);
        foreach (RaycastHit2D hit in collide)
        {
            if (hit.collider != null && hit.collider.gameObject.tag == "Ground")
            {
                return true;
            }
        }
        return false;
    }

    void scaleChange()
    {
        int rand = Random.Range(-1, 2);
        switch (rand)
        {
            case -1:
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                break;
            case 0:
                transform.localScale = new Vector3(1, 1, 1);
                break;
            case 1:
                transform.localScale = new Vector3(2, 2, 2);
                break;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 1f * transform.localScale.x);
    }

    void rotate()
    {
        float rotatDir = Random.Range(-1f, 2f);
        rb.AddTorque(rotateForce * rotatDir * transform.localScale.x, ForceMode2D.Impulse);
    }
}
