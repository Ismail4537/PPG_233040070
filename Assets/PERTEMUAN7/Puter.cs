using UnityEngine;

public class Puter : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        pencet();
    }
    void pencet()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(0, 0, 3f);
        }
    }

}
