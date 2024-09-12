using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int idx = 0;

    public GameObject front;
    public GameObject back;
    public SpriteRenderer frontImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setting(int number) //매게변수
    {
        idx=number;
        frontImage.sprite = Resources.Load<Sprite>($"MainScene\\Character_each\\Character{idx}"); //<자료형>(경로 즉 파일명)|$"문자{변수}"
    }
}
