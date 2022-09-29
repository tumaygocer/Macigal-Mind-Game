using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{


    int firstchoicevalue;
    GameObject ClickedObject;
    public Sprite DefaultSprite;
    GameObject SelectedButton;
    



    void Start()
    {
        firstchoicevalue = 0;
    }

    public void SelectObject(GameObject Objem)
    {
        ClickedObject = Objem;
        ClickedObject.GetComponent<Image>().sprite = ClickedObject.GetComponentInChildren<SpriteRenderer>().sprite;
    }

    public void ButtonClicked(int value)
    {
        Control(value, ClickedObject);
    }

    void Control(int SelectedValue, GameObject SelectedObject)
    {
        if (firstchoicevalue == 0)
        {
            firstchoicevalue = SelectedValue;
            SelectedButton = SelectedObject;
        }
        else
        {
            if (firstchoicevalue == SelectedValue)
            {
                Debug.Log("eþleþti");
                firstchoicevalue = 0;
            }
            else
            {
                SelectedButton.GetComponent<Image>().sprite = DefaultSprite;
                SelectedObject.GetComponent<Image>().sprite = DefaultSprite;
                Debug.Log("eþleþmedi");
                firstchoicevalue = 0;
            }

        }
    }
}
