using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject endPanel;
    private AudioSource audioSource;
    public AudioClip clip;
    public Text TimeTxt;
    public Text nowScore;
    public Text bestScore;

    bool isPlay = true;
    //public static bool isUnlock;
    int data_Stage = 0;
    int data_Card = 8;
    float data_Time = 60.0f;
    bool data_Gimmick = false;
    int cardCount;
    //string key = "bestScore";


    public Card firstCard;
    public Card secondCard;

    public int gimmickInterval = 4;
    int gimmickCount = 0;

    bool cheatUsed = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        data_Stage = GameData.Instance.stageNum;
        data_Card = GameData.Instance.cardSet;
        data_Gimmick = GameData.Instance.actGimmick;
        data_Time = GameData.Instance.timeSet;

        cardCount = data_Card;

        Time.timeScale = 1.0f;
        audioSource = GetComponent<AudioSource>();

        gimmickCount = gimmickInterval;

        cheatUsed = false;
    }
// Update is called once per frame
    void Update()
    {
        if(isPlay)
        {
            data_Time -= Time.deltaTime;
            TimeTxt.text = data_Time.ToString("N2");

            //Game Over
            if (data_Time <= 0.0f)
            {
                EndGame(false);
            }
        }

        //Cheat Code
        if (Input.GetKeyDown(KeyCode.Space) && cheatUsed == false)
        {
            cheatUsed = true;

            EndGame(true);
        }
        else if (Input.GetKeyDown(KeyCode.Backspace) && cheatUsed == false)
        {
            cheatUsed = true;

            EndGame(false);
        }
    }

    public void Matched()
    {
        if (firstCard.idx == secondCard.idx)
        {
            audioSource.PlayOneShot(clip);

            firstCard.DestroyCard();
            secondCard.DestroyCard();
            cardCount -= 2;

            //Game Clear
            if (cardCount == 0)
            {
                EndGame(true);
            }
        }
        else
        {
            firstCard.CloseCard();
            secondCard.CloseCard();

            //Gimmick
            if (GameData.Instance.actGimmick)
            {
                if (cardCount >= 4)
                {
                    gimmickCount--;
                    if (gimmickCount <= 0)
                    {
                        Board.Instance.SuffleRandomChild(firstCard.transform, secondCard.transform);
                        gimmickCount = gimmickInterval;
                    }
                }
            }
        }

        firstCard = null;
        secondCard = null;
    }

    void EndGame(bool isClear)
    {
        isPlay = false;

        if(isClear == false)
        {
            data_Time = 0.0f;
            TimeTxt.text = data_Time.ToString("N2");
        }
        Time.timeScale = 0;
        nowScore.text = data_Time.ToString("N2");
        endPanel.SetActive(true);

        string keyBest = "";
        string keyUnlock = "";
        switch (GameData.Instance.stageNum)
        {
            case 0: keyBest = GameData.Instance.bestEasy; keyUnlock = GameData.Instance.unlockNormal; break;
            case 1: keyBest = GameData.Instance.bestNormal; keyUnlock = GameData.Instance.unlockHard; break;
            case 2: keyBest = GameData.Instance.bestHard; keyUnlock = GameData.Instance.unlockHidden; break;
            case 3: keyBest = GameData.Instance.bestHard; break;
        }

        if (isClear)
        {
            if (PlayerPrefs.HasKey(keyBest))
            {
                float best = PlayerPrefs.GetFloat(keyBest);
                if (best < data_Time)
                {
                    PlayerPrefs.SetFloat(keyBest, data_Time);
                    bestScore.text = data_Time.ToString("N2");
                }
                else
                {
                    bestScore.text = best.ToString("N2");
                }
            }
            else
            {
                PlayerPrefs.SetFloat(keyBest, data_Time);
                bestScore.text = data_Time.ToString("N2");
            }

            switch (GameData.Instance.stageNum)
            {
                case 0:
                    PlayerPrefs.SetInt(keyUnlock, 1);
                    break;
                case 1:
                    PlayerPrefs.SetInt(keyUnlock, 1);
                    break;
                case 2:
                    if (data_Time > 5)
                    {
                        PlayerPrefs.SetInt(keyUnlock, 1);
                    }
                    break;
            }
        }
        else
        {
            if (PlayerPrefs.HasKey(keyBest) && PlayerPrefs.GetFloat(keyBest) > 0.0f)
            {
                float best = PlayerPrefs.GetFloat(keyBest);
                bestScore.text = best.ToString("N2");
            }
            else
            {
                PlayerPrefs.SetFloat(keyBest, data_Time);
                bestScore.text = "Empty";
            }
        }
    }
}