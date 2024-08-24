using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Appear : MonoBehaviour
{
    [SerializeField]
    private Image[] images;

    private TextMeshProUGUI[] texts;

    [SerializeField]
    private bool increaseAlpha;

    [SerializeField]
    private bool decreaseAlpha;

    [SerializeField]
    private float increaseSpeed = 10;

    [SerializeField]
    private float decreaseSpeed = 10;


    public void cancelAllApprearing()
    {
        increaseAlpha = false;
        decreaseAlpha = false;
    }
    
    public void startAppearing()
    {
        this.gameObject.SetActive(true);
        this.increaseAlpha = true;
        this.decreaseAlpha = false;
    }

    public void startDisappearing()
    {
        this.increaseAlpha = false;
        this.decreaseAlpha = true;
    }

    void Start()
    {
        texts = GetComponentsInChildren<TextMeshProUGUI>();
        images = GetComponentsInChildren<Image>();
    }

    void Update()
    {
        if (!increaseAlpha && !decreaseAlpha)
        {
            return;
        }

        foreach (TextMeshProUGUI text in texts)
        {
            handleText(text);
        }
        foreach (Image image in images)
        {
            handleImage(image);
        }
    }

    private void handleText(TextMeshProUGUI text)
    {
        if (increaseAlpha)
        {
            if (text.alpha < 1)
            {
                text.alpha += increaseSpeed * Time.deltaTime;
                if (text.alpha >= 1)
                {
                    increaseAlpha = false;
                }

            }
        }
        if (decreaseAlpha)
        {
            if (text.alpha > 0)
            {
                text.alpha -= decreaseSpeed * Time.deltaTime;
            }
            if (text.alpha <= 0)
            {
                this.gameObject.SetActive(false);
            }
        }
    }

    private void handleImage(Image image)
    {
        if (increaseAlpha)
        {
            Color c = image.color;
            if (c.a < .3f)
            {
                c.a = 0.3f;
            }
            if (c.a < 1)
            {
                c.a += increaseSpeed * Time.deltaTime;

                if (c.a >= 1)
                {
                    c.a = 1;
                    increaseAlpha = false;
                }

                image.color = c;
            }
        }
        if (decreaseAlpha)
        {
            Color c = image.color;
            c.a -= decreaseSpeed * Time.deltaTime;
            image.color = c;
            if (c.a <= 0)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
