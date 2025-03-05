using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingSpikes : MonoBehaviour
{
    public Vector3 movVector;
    

    // Update is called once per frame
    void Update()
    {
        this.transform.position += movVector * Time.deltaTime; 
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene("ForthLevel");
    }
}
