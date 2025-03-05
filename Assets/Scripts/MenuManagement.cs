using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
    private string[] selection = { "Play", "Exit" };
    public string selectedOption;

    public AudioSource src;
    public AudioClip aClip; 

    // Start is called before the first frame update
    void Start()
    {
        selectedOption = selection[0]; 
        src.clip = aClip;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            selectedOption = selection[1];
            src.Play();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            selectedOption = selection[0];
            src.Play();

        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Tab)) 
        {
            if(selectedOption == "Play")
                SceneManager.LoadScene("FirstLevel");

            if (selectedOption == "Exit")
                Application.Quit();
        }            
        

    }

    public string returnSelection() 
    {
        return selectedOption;
    }
}
