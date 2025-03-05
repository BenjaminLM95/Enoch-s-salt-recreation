using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TriesManagement : MonoBehaviour
{
    public int tries;
    public int currentTries;
    public int maxTries;
    public TextMeshProUGUI countTries;
    public Scene _currentScene;
    private bool _switch = true;

    public GameObject TitleSprite;

    // Start is called before the first frame update
    void Start()
    {
        maxTries = 5;
        currentTries = maxTries;
        tries = maxTries;
        countTries.text = "Tries: " + currentTries;
        
        

    }

    // Update is called once per frame
    void Update()
    {
        _currentScene = SceneManager.GetActiveScene();

        if (currentTries != tries) 
        {
            currentTries = tries;

            if(_currentScene.name != "FistLevel") 
            {
                countTries.text = "Souls: " + currentTries;
            }
            else
            countTries.text = "Tries: " + currentTries;
        }

        if (_currentScene.name == "SpikeScene")
        {
            countTries.gameObject.SetActive(false); TitleSprite.gameObject.SetActive(false);
        }
        else
        {
            countTries.gameObject.SetActive(true); TitleSprite.gameObject.SetActive(true);
        }


        if (_currentScene.name != "FirstLevel" && _switch)
        {
            countTries.text = "Souls: " + currentTries;
            _switch = false;
        }

        if(currentTries <= 0)
            Application.Quit();

    }

    public void decreasedTries() 
    {
        tries--;
    }

    public void restoreTries() 
    {
        tries = maxTries; 
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.gameObject.CompareTag("Ball") && col.gameObject.name == "Ball") 
        {
            decreasedTries(); 
        }
    }

}
