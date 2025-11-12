using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BtnObjectRight : MonoBehaviour
{

    public GameObject flower;
    public GameObject flowerRight;
    
    public TMP_Text text;
    public SelectOptionBtn selectOptionBtn;
    public GameObject option;
    public void ClickObjectRight()
    {
        transform.parent.parent.GetChild(1).gameObject.SetActive(false);
        transform.parent.parent.GetChild(2).gameObject.SetActive(false);
        flower.SetActive(false);
        flowerRight.SetActive(true);

        text.text = "right";
        selectOptionBtn.enabled = false;
        option.SetActive(false);
    }
}
