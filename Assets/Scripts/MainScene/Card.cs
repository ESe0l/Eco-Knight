using UnityEngine;

public class Card : MonoBehaviour
{
    public int idx = 0;

    public GameObject front;
    public GameObject back;
    public SpriteRenderer frontImage;
    public Animator anim;

    private AudioSource audioSource;
     public AudioClip clip;

    //Gimmick
    public bool actMove = false;
    public Vector3 moveDest = Vector3.zero;
    Vector3 velocity = Vector3.zero;
    float moveTime = 0.0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Gimmick
        if (actMove)
        {
            actMove = false;
            moveTime = 0.5f;
        }
        if (moveTime > 0f)
        {
            moveTime -= Time.deltaTime;
            transform.position = Vector3.SmoothDamp(transform.position, moveDest, ref velocity, 0.1f);
        }
    }

    public void Setting(int number)
    {
        idx = number;
        frontImage.sprite = Resources.Load<Sprite>($"MainScene\\Character_each\\Character{idx}");
    }

    public void OpenCard()
    {
        audioSource.PlayOneShot(clip);

        anim.SetBool("isOpen", true);
        front.SetActive(true);
        back.SetActive(false);

        if (GameManager.Instance.firstCard == null)
        {
            GameManager.Instance.firstCard = this;
        }
        else
        {
            GameManager.Instance.secondCard = this;
            GameManager.Instance.Matched();
        }
    }

    public void DestroyCard()
    {
        Invoke("DestroyCardInvoke", 1.0f);
    }
    public void DestroyCardInvoke()
    {
        Destroy(gameObject);
    }
    public void CloseCard()
    {
        Invoke("CloseCardInvoke", 1.0f);
    }
    public void CloseCardInvoke()
    {
        anim.SetBool("isOpen", false);
        front.SetActive(false);
        back.SetActive(true);
    }
}