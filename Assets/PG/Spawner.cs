using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform[] points;
    [SerializeField] GameObject LemonPrefab;
    Transform curTargetPoint;
    Rigidbody2D rb;
    public float speed = 2f;
    public float spawnInterval = 2f;
    public float spawnAngle = 45f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        curTargetPoint = points[0];
        InvokeRepeating("SpawnLemon", 1f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void SpawnLemon()
    {
        float angle = spawnAngle * Mathf.Deg2Rad;
        Quaternion rotation = new Quaternion(0, 0, Mathf.Sin(Random.Range(-angle, angle) / 2), Mathf.Cos(angle / 2));
        GameObject lemon = Instantiate(LemonPrefab, transform.position, rotation);
        lemon.transform.localScale = Vector3.one * Random.Range(0.25f, 1.25f);
        lemon.transform.localScale = new Vector3(Random.Range(-lemon.transform.localScale.x, lemon.transform.localScale.x) > 0 ? lemon.transform.localScale.x : -lemon.transform.localScale.x, lemon.transform.localScale.y, lemon.transform.localScale.z);
    }

    void Movement()
    {
        Vector2 direction = (curTargetPoint.position - transform.position).normalized;
        rb.velocity = direction * speed;

        if (Vector2.Distance(transform.position, curTargetPoint.position) < 0.1f)
        {
            curTargetPoint = points[Random.Range(0, points.Length)];
        }
    }
}
