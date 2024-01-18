using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public RigidBody2D rigidBody;
    public GameObject missilePrefab
    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(missilePrefab, spawn.position, spawn.rotation);
    }
}
