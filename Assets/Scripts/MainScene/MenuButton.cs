using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public GameObject menuPanel;
    public Button menuBtn;
    public GameObject cardBoard;

    public void OpenMenu()
    {
        Time.timeScale = 0;
        menuPanel.SetActive(true);
        menuBtn.interactable = false;
        cardBoard.SetActive(false);
    }
}
