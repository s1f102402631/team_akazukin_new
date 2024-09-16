using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplayCtrl : MonoBehaviour
{
    public void Display(string words)
    {
        GetComponent<TextMeshProUGUI>().text = words;
    }

    public void Delete()
    {
        GetComponent<TextMeshProUGUI>().text = "";
    }

    // Start is called before the first frame update
    void Start()
    {
        Delete();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
