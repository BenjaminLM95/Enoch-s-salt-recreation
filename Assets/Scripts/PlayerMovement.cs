using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed;
    private Vector3 movement;
    public bool ismoving;
    Animator c_Animator;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;
        movement = new Vector3(1, 0, 0);
        ismoving = false;
        c_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += movement * speed;
            ismoving = true;
            c_Animator.SetBool("Moving", ismoving);
        }
        

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position -= movement * speed;
            c_Animator.SetBool("Moving", ismoving);
        }
        

        c_Animator.SetBool("Moving", ismoving);
    }
}
