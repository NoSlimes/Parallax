using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yes : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField]bool IsAlwaysOn;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        if(IsAlwaysOn || Input.GetButton("Fire1"))
        {
            spriteRenderer.color = Random.ColorHSV();
        }
        else
            spriteRenderer.color = Color.white;
        }
}
