using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Switch : MonoBehaviour
{
    SpriteRenderer spriterenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        spriterenderer.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with switch");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger with switch");
        spriterenderer.color = Color.red;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriterenderer.color = Color.green;
    }
}
