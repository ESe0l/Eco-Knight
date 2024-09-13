using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public int buttonIdx = 0; // 0 - Reset   1 - cancel   2 - confirm

    public GameObject optionPanel;
    public GameObject resetPanel;
    public Button startBtn;
    public Button optionBtn;

    public void ClickButton()
    {
        if (buttonIdx == 0)
        {
            optionPanel.SetActive(false);
            resetPanel.SetActive(true);
            startBtn.interactable = false;
            optionBtn.interactable = false;
        }
        else if (buttonIdx == 1)
        {
            optionPanel.SetActive(false);
            resetPanel.SetActive(false);
            startBtn.interactable = true;
            optionBtn.interactable = true;

            OptionButton temp = optionBtn.GetComponent<OptionButton>();
            temp.Set_isOpen(false);
        }
        else if (buttonIdx == 2)
        {
            //Data Reset
            PlayerPrefs.SetFloat("bestScoreEasy", 0f);
            PlayerPrefs.SetFloat("bestScoreNormal", 0f);
            PlayerPrefs.SetFloat("bestScoreHard", 0f);
            PlayerPrefs.SetFloat("bestScoreHidden", 0f);
            PlayerPrefs.SetInt("unlockNormal", 0);
            PlayerPrefs.SetInt("unlockHard", 0);
            PlayerPrefs.SetInt("unlockHidden", 0);

            optionPanel.SetActive(false);
            resetPanel.SetActive(false);
            startBtn.interactable = true;
            optionBtn.interactable = true;

            OptionButton temp = optionBtn.GetComponent<OptionButton>();
            temp.Set_isOpen(false);
        }
    }
}
