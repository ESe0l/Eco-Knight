using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScrolling : MonoBehaviour
{   
    public Image background;
    public float backgroundSpeed = 0.1f;

    Vector2 backgroundScrollOffset = Vector2.zero;

    private void Start() 
    {
        background = transform.Find("Building").GetComponent<Image>();
    }

    private void Update() 
    {
        ScrollBackgroundImage();
    }
    void ScrollBackgroundImage()
    {
        backgroundScrollOffset.x += (backgroundSpeed * Time.deltaTime);
        background.material.mainTextureOffset = backgroundScrollOffset;
    }
}
