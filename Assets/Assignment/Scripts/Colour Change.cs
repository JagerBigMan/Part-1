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

}
