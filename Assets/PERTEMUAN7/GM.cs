using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    RaycastHit2D[] hits;
    GameObject pair1, pair2, tmp;
    int i;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        hits = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hits.Length > 0)
            tmp = hits[hits.Length - 1].transform.gameObject;
    }
    public void setPair1(GameObject go)
    {
        pair1 = go;
    }
    public void setPair2()
    {
        pair2 = tmp;
    }
    public bool valid()
    {
        bool ntx = false;
        if (pair1.tag == pair2.tag)
            ntx = true;
        return ntx;
    }
}
