using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class ClickSelect : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI selectText;
 
    public void SelectA()
    {
        selectText.text = "How to play";
    }
 
    public void SelectB()
    {
        selectText.text = "Selected B";
    }
}
