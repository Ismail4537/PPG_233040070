using UnityEngine;

public class Tembak : MonoBehaviour
{
    [SerializeField] GameObject peler;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tembak();
    }

    void tembak()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(peler, transform.position, Quaternion.identity); //B
        }
    }
}
