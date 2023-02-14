using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
 public SpriteRenderer spriteRenderer;
    public float minSize = 1.0f;
    public float maxSize = 2.0f;

    void Start()
    {   
        spriteRenderer= GetComponent<SpriteRenderer>();
        float size = Random.Range(minSize, maxSize);
        Vector3 scale = spriteRenderer.transform.localScale;
        scale.x = size;
        scale.y = size;
        spriteRenderer.transform.localScale = scale;
        spriteRenderer.color= Random.ColorHSV();
    }

    
}
