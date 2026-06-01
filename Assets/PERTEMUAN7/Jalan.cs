using UnityEngine;

public class Jalan : MonoBehaviour
{
    public float speed;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
            transform.Translate(Vector2.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime);
        if (Input.GetAxis("Vertical") != 0)
            transform.Translate(Vector2.up * speed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}