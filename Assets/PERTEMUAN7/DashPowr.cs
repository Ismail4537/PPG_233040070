using UnityEngine;
public class DashPowr : MonoBehaviour
{
    float powr;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            powr += 0.5f; //A
        }
        if (Input.GetKeyUp(KeyCode.Space))
        { //A
            GetComponent<Rigidbody2D>().AddForce(new Vector2(powr, 0)); //B
            powr = 0; //A
        }
    }

}