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
    int data_Stage = 0;
    int data_Card = 8;
    float data_Time = 60.0f;
    bool data_Gimmick = false;
    int cardCount;
    string key = "bestScore";


    public Card firstCard;
    public Card secondCard;

    public int gimmickInterval = 4;
    int gimmickCount = 0;

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
    }
// Update is called once per frame
    void Update()
    {
        if(isPlay)
        {
        data_Time -= Time.deltaTime;
        TimeTxt.text = data_Time.ToString("N2");
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
            
            if (cardCount == 0)
            {
                isPlay = false;
                Time.timeScale = 0;
                nowScore.text = data_Time.ToString("N2");
                endPanel.SetActive(true);


                if (PlayerPrefs.HasKey(key))
                {
                    float best = PlayerPrefs.GetFloat(key);
                    if(best < data_Time)
                    {
                        PlayerPrefs.SetFloat(key, data_Time);
                        bestScore.text = data_Time.ToString("N2");
                    } 
                    else
                    {
                        bestScore.text = best.ToString("N2");
                    }
                }
                else
                {
                    PlayerPrefs.SetFloat(key, data_Time);
                    bestScore.text = data_Time.ToString("N2");
                }
            }
        }
        else
        {
            firstCard.CloseCard();
            secondCard.CloseCard();

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
}