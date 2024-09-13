using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject cardBoard;
    public Button menubutton;

    public void OpenMenu()
    {
        Time.timeScale = 0;
        menuPanel.SetActive(true);
        cardBoard.SetActive(false);
        menubutton.interactable = false;
    }
}
