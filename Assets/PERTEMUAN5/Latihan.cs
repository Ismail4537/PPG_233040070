using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hola espuma, estoy " + gameObject.name + ", y estoy en la posición " + gameObject.GetComponent<Rigidbody2D>().bodyType);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
