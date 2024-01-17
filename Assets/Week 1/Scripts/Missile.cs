using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rigidbody;
    public GameObject missilePrefab;

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        rigidbody.MovePosition(rigidbody.position + direction);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player hit by " + collision.gameObject);
        Destroy(gameObject);
    }
}
