using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBeheavor : MonoBehaviour
{
    public int maxHp;
    private int currentHp;
    [SerializeField] private int hp;
    public SpriteRenderer spriteRenderer; 
    public Sprite _spriteHP1;
    public Sprite _spriteHP2;   
    public Sprite _spriteDefault;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        hp = maxHp;
        currentHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp != currentHp)
        {
            hp = currentHp;
            if (hp > 0)
                UpdateSprite(hp); 
            else
                this.gameObject.SetActive(false);
        }

        
    }

    public void UpdateSprite(int health) 
    {
        switch (health) 
        {            
            case 2:
                spriteRenderer.sprite = _spriteHP2; 
                break;
            case 1:
                spriteRenderer.sprite = _spriteHP1;
                break;
            default:
                spriteRenderer.sprite = _spriteDefault;
                break;

        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("Hit");
        if (collision.gameObject.CompareTag("Ball")) 
        {
            Debug.Log("Hit by the ball"); 
            currentHp--; 
            if(currentHp < 0)
                currentHp = 0;
        }
    }
    

}
