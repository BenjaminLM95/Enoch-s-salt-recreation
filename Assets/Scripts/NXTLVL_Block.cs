using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NXTLVL_Block : MonoBehaviour
{
    private bool hit;
    public SpriteRenderer spriteRenderer;
    public Sprite _spriteDefault;
    public Sprite _spriteHit;
    // Start is called before the first frame update
    void Start()
    {
        hit = false;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = _spriteDefault;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!hit)
            {
                hit = true;
                spriteRenderer.sprite = _spriteHit;
            }
        }
    }
}
