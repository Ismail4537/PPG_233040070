using UnityEngine;

public class DeragPelac : MonoBehaviour
{
    Vector3 posisiAwal;
    // Use this for initialization
    void Start()
    {
        posisiAwal = transform.position;
    }
    public void OnMouseDown()
    {
        GameObject.Find("GM").GetComponent<GM>().setPair1(gameObject);
    }
    public void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
    }
    public void OnMouseUp()
    {
        transform.position = posisiAwal;
        GameObject.Find("GM").GetComponent<GM>().setPair2();
        if (GameObject.Find("GM").GetComponent<GM>().valid())
            Destroy(gameObject);
    }
}
