using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    public Slider volSlider;
    public Text volTxt;

    //SpaceWalk 0-Red 1-Blue 2-Pink
    public GameObject redChar;
    public GameObject blueChar;
    public GameObject pinkChar;
    float[] waitingTime = new float[3];
    bool[] isWalking = new bool[3];
    Vector3[] locDprt = new Vector3[3];
    Vector3[] locDst = new Vector3[3];
    float[] moveSpeed = new float[3];
    float[] rotSpeed = new float[3];

    // Start is called before the first frame update
    void Start()
    {

        float value = AudioManager.Instance.GetVolume();
        volSlider.value = value;
        volTxt.text = (value * 100).ToString("N0");

        //SpaceWalk
        int departOrder = Random.Range(0, 6);
        switch (departOrder)
        {
            case 0 : waitingTime[0] = 7f; waitingTime[1] = 14f; waitingTime[2] = 21f; break;
            case 1 : waitingTime[0] = 7f; waitingTime[1] = 21f; waitingTime[2] = 14f; break;
            case 2 : waitingTime[0] = 14f; waitingTime[1] = 7f; waitingTime[2] = 21f; break;
            case 3 : waitingTime[0] = 14f; waitingTime[1] = 21f; waitingTime[2] = 7f; break;
            case 4 : waitingTime[0] = 21f; waitingTime[1] = 7f; waitingTime[2] = 14f; break;
            case 5 : waitingTime[0] = 21f; waitingTime[1] = 14f; waitingTime[2] = 7f; break;
        }
        waitingTime[0] += Random.Range(2f, 4f);
        waitingTime[1] += Random.Range(2f, 4f);
        waitingTime[2] += Random.Range(2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        //SpaceWalk
        for (int i = 0; i < 3; i++)
        {
            if (isWalking[i] == false)
            {
                waitingTime[i] -= Time.deltaTime;
                if (waitingTime[i] < 0)
                {
                    int departSide = Random.Range(0, 4);
                    switch (departSide)
                    {
                        case 0 : locDprt[i] = new Vector3(Random.Range(-1.4f, 1.4f), 7.5f, -5); locDst[i] = new Vector3(Random.Range(-1.4f, 1.4f), -7.5f, -5); break;
                        case 1 : locDprt[i] = new Vector3(5.0f, Random.Range(-3.25f, 3.25f), -5); locDst[i] = new Vector3(-5.0f, Random.Range(-3.25f, 3.25f), -5); break;
                        case 2 : locDprt[i] = new Vector3(Random.Range(-1.4f, 1.4f), -7.5f, -5); locDst[i] = new Vector3(Random.Range(-1.4f, 1.4f), 7.5f, -5); break;
                        case 3 : locDprt[i] = new Vector3(-5.0f, Random.Range(-3.25f, 3.25f), -5); locDst[i] = new Vector3(5.0f, Random.Range(-3.25f, 3.25f), -5); break;
                    }
                    moveSpeed[i] = Random.Range(0.9f, 1.0f);
                    rotSpeed[i] = Random.Range(-0.05f, 0.05f);
                    switch (i)
                    {
                        case 0: redChar.transform.position = locDprt[i]; break;
                        case 1: blueChar.transform.position = locDprt[i]; break;
                        case 2: pinkChar.transform.position = locDprt[i]; break;
                    }
                    isWalking[i] = true;
                }
            }
            else
            {
                switch (i)
                {
                    case 0: redChar.transform.position = Vector3.MoveTowards(redChar.transform.position, locDst[i], Time.deltaTime * moveSpeed[i]); redChar.transform.Rotate(new Vector3(0, 0, rotSpeed[i])); break;
                    case 1: blueChar.transform.position = Vector3.MoveTowards(blueChar.transform.position, locDst[i], Time.deltaTime * moveSpeed[i]); blueChar.transform.Rotate(new Vector3(0, 0, rotSpeed[i])); break;
                    case 2: pinkChar.transform.position = Vector3.MoveTowards(pinkChar.transform.position, locDst[i], Time.deltaTime * moveSpeed[i]); pinkChar.transform.Rotate(new Vector3(0, 0, rotSpeed[i])); break;
                }

                float dist = 0.0f;
                switch (i)
                {
                    case 0: dist = Vector3.Distance(redChar.transform.position, locDst[i]); break;
                    case 1: dist = Vector3.Distance(blueChar.transform.position, locDst[i]); break;
                    case 2: dist = Vector3.Distance(pinkChar.transform.position, locDst[i]); break;
                }
                if (dist < 0.01f)
                {
                    waitingTime[i] += Random.Range(15f, 17f);
                    isWalking[i] = false;
                }
            }
        }
    }
}