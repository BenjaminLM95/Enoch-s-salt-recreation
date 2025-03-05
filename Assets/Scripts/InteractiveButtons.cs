using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveButtons : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite BtnSelected;
    public Sprite BtnDiselected;
    public MenuManagement _menuManagement;
    public string _nameSelected; 
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_nameSelected == _menuManagement.returnSelection()) 
        {
            spriteRenderer.sprite = BtnSelected;
        }
        else 
        {
            spriteRenderer.sprite = BtnDiselected;
        }


    }
}
