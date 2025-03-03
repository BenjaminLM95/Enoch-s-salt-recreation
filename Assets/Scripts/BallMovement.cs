using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Vector3 pos = new Vector3();
    float bulletSpeed = 5.0f;
    public RaycastHit2D hit;
    public LayerMask obstacles;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(1, 1, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += pos * bulletSpeed * Time.deltaTime;
        hit = Physics2D.Raycast(transform.position, pos, 0.4f, obstacles);

        if (hit)
        {
            pos = Vector3.Reflect(pos, hit.normal);
            Debug.Log("reflect");
        }
            


    }
    

}
