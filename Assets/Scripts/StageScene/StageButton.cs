using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageButton : MonoBehaviour
{
    public GameObject Btn_E;
    public GameObject Btn_N;
    public GameObject Btn_H;

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}