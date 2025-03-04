using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelManagement : MonoBehaviour
{
    public int nxtlvlPoints;
    public int maxPoints;
    public string nextLevel; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onePoint() 
    {
        if (nxtlvlPoints < maxPoints)
        {
            nxtlvlPoints++;
            if(nxtlvlPoints == maxPoints )
            SceneManager.LoadScene(nextLevel);
        }
    }
}
