using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorcontroller : MonoBehaviour
{
    private Color originalColor;
    private SpriteRenderer spriteRenderer;
    public KeyCode keyToHold = KeyCode.Space; // Phím để giữ và thay đổi màu

    public Color colorWhileHolding = Color.black; // Màu khi giữ phí

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyToHold))
        {
            ChangeColor(colorWhileHolding);
        }
        else 
        {
            ChangeColor(originalColor); 
        }
    }
    void ChangeColor(Color newColor)
    {
        spriteRenderer.color = newColor;
    }
}
