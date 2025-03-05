using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Vector3 pos = new Vector3();
    float bulletSpeed = 5.0f;
    float iBulletSpeed = 5.0f; 
    public RaycastHit2D hit;
    public LayerMask obstacles;
    private Vector3 initialPosition;   


    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(1, 1, 0);        
        initialPosition = this.gameObject.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += pos * bulletSpeed * Time.deltaTime;
        hit = Physics2D.Raycast(transform.position, pos, 0.1f, obstacles);

        if (hit)
        {
            pos = Vector3.Reflect(pos, hit.normal);
            

        } 

        if(this.gameObject.transform.position.y < -10) 
        {
            if (this.name == "Ball")
            {
                Debug.Log("-1 point");
                this.gameObject.transform.position = initialPosition;
                bulletSpeed = iBulletSpeed;
                pos = new Vector3(1, 1, 0);
            }
            else
            {
                this.gameObject.SetActive(false); 
            }
        }
            


    }

    public void ballfaster()
    {
        bulletSpeed *= 1.25f;
    }

}
