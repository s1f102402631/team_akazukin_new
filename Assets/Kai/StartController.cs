using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Unityエンジンのシーン管理プログラムを利用する

public class StartController : MonoBehaviour //StartControllerという名前にします
{
        public void change_button() //change_buttonという名前にします
        {
            SceneManager.LoadScene("Hard");//secondを呼び出します
        }
}
