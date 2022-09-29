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
        Control(value);
    }

    void Control(int SelectedValue)
    {
        if (firstchoicevalue == 0)
        {
            firstchoicevalue = SelectedValue;
            SelectedButton = ClickedObject;
        }
        else
        {
            StartCoroutine(StandbyTime(SelectedValue));

        }
    }
    IEnumerator StandbyTime(int SelectedValue)
    {
        yield return new WaitForSeconds(1);

        if (firstchoicevalue == SelectedValue)
        {
            Destroy(SelectedButton.gameObject);
            Destroy(ClickedObject.gameObject);
            Debug.Log("eþleþti");
            firstchoicevalue = 0;
            SelectedButton = null;
        }
        else
        {
            SelectedButton.GetComponent<Image>().sprite = DefaultSprite;
            ClickedObject.GetComponent<Image>().sprite = DefaultSprite;
            Debug.Log("eþleþmedi");
            firstchoicevalue = 0;
            SelectedButton = null;
        }
    }
}
