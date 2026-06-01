using UnityEngine;

public class Hover : MonoBehaviour
{
    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }


}
