using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    // Declare our sprintRendered componment
    public SpriteRenderer theRenderer;

    // Declare custom color for a variable
    public Color customColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theRenderer = GetComponent<SpriteRenderer>();
        // Acess the "color" property of the spriteRenderer compment and change its value to green
        if (theRenderer != null)
        {
            theRenderer.color = customColor;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
