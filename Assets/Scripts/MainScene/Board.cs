using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Board : MonoBehaviour
{
    public Transform cards;
    public GameObject card;

    int data_Card = 8;
    
    // Start is called before the first frame update
    void Start()
    {
        data_Card = GameData.Instance.cardSet;
        
        int[] arr;
        Vector3 boardSize = new Vector3();
        switch (data_Card)
        {
            case 8:
                arr = new int[8]{ 0, 0, 1, 1, 2, 2, 3, 3 };
                arr = arr.OrderBy(x => UnityEngine.Random.Range(0f, 1f)).ToArray();

                for (int i = 0; i < 4; i++)
                {
                    GameObject go = Instantiate(card, this.transform);

                    float x = (i / 3) * 1.4f - 1.4f;
                    float y = (i % 3) * 1.4f - 2.0f;
                    go.transform.position = new Vector2(x, y);

                    go.GetComponent<Card>().Setting(arr[i]);
                }
                for (int i = 4; i < 8; i++)
                {
                    GameObject go = Instantiate(card, this.transform);

                    float x = ((i + 1) / 3) * 1.4f - 1.4f;
                    float y = ((i + 1) % 3) * 1.4f - 2.0f;
                    go.transform.position = new Vector2(x, y);

                    go.GetComponent<Card>().Setting(arr[i]);
                }
                boardSize = new Vector3(1.2f, 1.2f, 1);

                break;

            case 16:
                arr = new int[16] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
                arr = arr.OrderBy(x => UnityEngine.Random.Range(0f, 1f)).ToArray();

                for (int i = 0; i < 16; i++)
                {
                    GameObject go = Instantiate(card, this.transform);

                    float x = (i / 4) * 1.4f - 2.1f;
                    float y = (i % 4) * 1.4f - 2.7f;
                    go.transform.position = new Vector2(x, y);

                    go.GetComponent<Card>().Setting(arr[i]);
                }
                this.transform.localScale = new Vector3(1, 1, 1);

                break;

            case 20:
                arr = new int[20] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };
                arr = arr.OrderBy(x => UnityEngine.Random.Range(0f, 1f)).ToArray();

                for (int i = 0; i < 20; i++)
                {
                    GameObject go = Instantiate(card, this.transform);

                    float x = (i / 4) * 1.1f - 2.2f;
                    float y = (i % 4) * 1.4f - 2.7f;
                    go.transform.position = new Vector2(x, y);

                    go.GetComponent<Card>().Setting(arr[i]);
                }
                this.transform.localScale = new Vector3(1, 1, 1);

                break;

            case 24:
                arr = new int[24] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11 };
                arr = arr.OrderBy(x => UnityEngine.Random.Range(0f, 1f)).ToArray();

                for (int i = 0; i < 12; i++)
                {
                    GameObject go = Instantiate(card, this.transform);

                    float x = (i / 5) * 1.1f - 2.2f;
                    float y = (i % 5) * 1.4f - 3.5f;
                    go.transform.position = new Vector2(x, y);

                    go.GetComponent<Card>().Setting(arr[i]);
                }
                for (int i = 12; i < 24; i++)
                {
                    GameObject go = Instantiate(card, this.transform);

                    float x = ((i + 1) / 5) * 1.1f - 2.2f;
                    float y = ((i + 1) % 5) * 1.4f - 3.5f;
                    go.transform.position = new Vector2(x, y);

                    go.GetComponent<Card>().Setting(arr[i]);
                }
                this.transform.localScale = new Vector3(1, 1, 1);

                break;

            case 30:
                arr = new int[30] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14 };
                arr = arr.OrderBy(x => UnityEngine.Random.Range(0f, 1f)).ToArray();

                for (int i = 0; i < 30; i++)
                {
                    GameObject go = Instantiate(card, this.transform);

                    float x = (i / 5) * 1.1f - 2.75f;
                    float y = (i % 5) * 1.4f - 3.5f;
                    go.transform.position = new Vector2(x, y);

                    go.GetComponent<Card>().Setting(arr[i]);
                }
                this.transform.localScale = new Vector3(0.9f, 0.9f, 1);

                break;

            default:
                Debug.Log("Invalid Card Set!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}