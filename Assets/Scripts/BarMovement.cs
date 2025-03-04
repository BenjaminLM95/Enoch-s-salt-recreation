using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement : MonoBehaviour
{
    private float speed;
    private Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
        movement = new Vector3(1, 0, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += movement * speed; 
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position -= movement * speed;
        }


    }
    
}
