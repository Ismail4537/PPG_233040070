using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleLatoh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0.5f, 0.5f, 0) * Time.deltaTime;
    }
}
