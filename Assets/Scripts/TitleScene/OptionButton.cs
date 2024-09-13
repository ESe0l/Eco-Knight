using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionButton : MonoBehaviour
{
    public GameObject optionPanel;
    public Button startBtn;

    bool isOpen = false;
    public void Set_isOpen(bool value)
    {
        isOpen = value;
    }

    public void ToggleOption()
    {
        if (isOpen == false)
        {
            isOpen = true;
            optionPanel.SetActive(true);
            startBtn.interactable = false;
        }
        else
        {
            isOpen = false;
            optionPanel.SetActive(false);
            startBtn.interactable = true;
        }
    }
}