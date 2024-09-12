using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButton : MonoBehaviour
{
    public GameObject menuPanel;
    public Button menuBtn;
    public GameObject cardBoard;

    public void CloseMenu()
    {
        menuPanel.SetActive(false);
        menuBtn.interactable = true;
        cardBoard.SetActive(true);
        Time.timeScale = 1.0f;
    }
}
