using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossBlock : MonoBehaviour
{
    private bool hit;   
    public SpriteRenderer spriteRenderer;
    public Sprite _spriteDefault;
    public Sprite _spriteHit;
    public GameObject _playerBar;
     
    // Start is called before the first frame update
    void Start()
    {
        hit = false;         
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = _spriteDefault;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {        
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!hit) {
                hit = true;                
                spriteRenderer.sprite = _spriteHit; 
                DecreaseBar();
            }
        }
    }

    public void DecreaseBar() 
    {
        _playerBar.gameObject.transform.localScale = new Vector3(_playerBar.gameObject.transform.localScale.x * 0.8f, 0.5f, 1f);         
    }
}
