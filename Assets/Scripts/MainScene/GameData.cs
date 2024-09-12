using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData Instance;

    public int stageNum = 0;        //�������� ��ȣ
    public int cardSet = 8;         //ī�� �ż�
    public float timeSet = 60.0f;   //�ð�����
    public bool actGimmick = false; //��� �߰�

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
