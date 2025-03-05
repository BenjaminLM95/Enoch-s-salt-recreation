using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearInSeconds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("setInactive", 3f); 
    }

    

    void setInactive() 
    {
        this.gameObject.SetActive(false);
    }
}
