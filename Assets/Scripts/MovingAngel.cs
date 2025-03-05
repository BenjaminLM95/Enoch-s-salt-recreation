using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAngel : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 movingVector;
    private float movingSpeed;
    private float direction;

    public BlockBeheavor _blockB;
    public int angelHP;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = this.transform.position;
        movingVector = new Vector3(-1f, 0f, 0f);
        direction = -1f;
        angelHP = _blockB.hp; 
    }

    // Update is called once per frame
    void Update()
    {
        movingVector = new Vector3(direction, 0f, 0f); 
        this.transform.position += movingVector * Time.deltaTime;

        if(angelHP!= _blockB.hp) 
        {
            angelHP = _blockB.hp;
            if (angelHP <= 0)
            {
                Application.Quit();
            }
        }

        
        
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Block"))
            direction *= -1; 
    }

}
