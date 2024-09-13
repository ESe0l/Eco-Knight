using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject cardBoard;
    public Button menubutton;

    public void CloseMenu()
    {
        menuPanel.SetActive(false);
        cardBoard.SetActive(true);
        menubutton.interactable = true;
        Time.timeScale = 1.0f;
    }
}
