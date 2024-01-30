using UnityEngine;

public class ColourChange : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color initialColor = Color.red;  
    public Color triggerColor = Color.green; 

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = initialColor;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ChangePlayerColor(triggerColor);
        }
    }

    private void ChangePlayerColor(Color newColor)
    {
        spriteRenderer.color = newColor;
    }
}
