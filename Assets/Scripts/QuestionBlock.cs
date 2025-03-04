using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBlock : MonoBehaviour
{
    private bool hit;
    public SpriteRenderer spriteRenderer;
    public Sprite _spriteDefault;
    public Sprite _spriteEffect1;
    public Sprite _spriteEffect2;
    public Sprite _spriteEffect3;
    public GameObject playerBar;
    public BallMovement _ballMovement;
    public GameObject extraBall;

    // Start is called before the first frame update
    void Start()
    {
        hit = false;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = _spriteDefault;
        playerBar = GameObject.Find("Bar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!hit)
            {
                hit = true;
                GetAnEffect(); 
            }
        }
    }

    private void GetAnEffect()
    {
        System.Random rnd = new System.Random();
        int number = rnd.Next(0, 100); 

        if(number < 40) 
        {
            spriteRenderer.sprite = _spriteEffect1;
            CreateSecondBall();
        }
        else if(number < 80)
        {
            spriteRenderer.sprite = _spriteEffect2;
            _ballMovement.ballfaster(); 
        }
        else 
        {
            spriteRenderer.sprite = _spriteEffect3;
            playerBar.gameObject.transform.localScale = new Vector3(2.5f, 0.5f, 1f);
        }

        Debug.Log(number); 
    }

    public void CreateSecondBall() 
    {
        GameObject tempBall = Instantiate(extraBall, new Vector3(0f, -2f, 0f), this.transform.rotation) as GameObject;
        Rigidbody2D tempRigidBodyBall = tempBall.GetComponent<Rigidbody2D>();
        tempRigidBodyBall.gravityScale = 0f;
    }

}
