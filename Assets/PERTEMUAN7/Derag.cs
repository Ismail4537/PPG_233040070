using UnityEngine;

public class Derag : MonoBehaviour
{
    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
    }

    void OnMouseUp()
    {
        print("Saya di drop");
    }
}
