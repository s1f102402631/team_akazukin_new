using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI弄るなら必須

public class SircleGuageSystem : MonoBehaviour
{
    float speed = 0.01f; //後で速度変更しやすいように敢えて変数にしている
    float i = 0;
    bool Increase = true;
    RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = this.GetComponent<RectTransform>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Increase)
        {
            i += speed;
        }
        else
        {
            i -= speed;
        }
        if (i >= 1)
        {
            Increase = false;
        }
        if (i <= 0)
        {
            Increase = true;
        }
        rectTransform.localScale = new Vector3(i, i, 0);
    }
}