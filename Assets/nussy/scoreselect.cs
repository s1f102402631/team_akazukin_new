using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreselect : MonoBehaviour
{
    public static int score = 0;
    public string select = "";
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void selectmap(string select)
    {
        this.select = select;
    }

    public string returnselect()
    {
        return select;
    }

    // Update is called once per frame

}
