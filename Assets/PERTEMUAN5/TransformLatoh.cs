using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformLatoh : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector2 (3f,3f);
        transform.position = new Vector2(-3f, 3f);
        // transform.position = new Vector2 (-3f,-3f);
        // transform.position = new Vector2 (3f,-3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
