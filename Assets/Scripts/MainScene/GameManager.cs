using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Text TimeTxt;
    public GameObject endTxt;
    private AudioSource audioSource;
    public AudioClip clip;
    public GameObject endPanel;

    int data_Stage = 0;
    int data_Card = 8;
    float data_Time = 60.0f;
    bool data_Gimmick = false;
    int cardCount;

    public Card firstCard;
    public Card secondCard;

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
    }
// Update is called once per frame
    void Update()
    {
        data_Time -= Time.deltaTime;
        TimeTxt.text = data_Time.ToString("N2");
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
                endPanel.SetActive(true);
                Time.timeScale = 0;
                GameData.Instance.stageUnlock = true;
            }
        }
        else
        {
            firstCard.CloseCard();
            secondCard.CloseCard();
        }

        firstCard = null;
        secondCard = null;
    }
}