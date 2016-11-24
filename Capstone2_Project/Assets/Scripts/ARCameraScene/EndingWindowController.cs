using UnityEngine;
using System.Collections;

public class EndingWindowController : MonoBehaviour
{

    void Awake()
    {
        gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        gameObject.SetActive(false);
    }

    public void OpenWindow()
    {
        gameObject.SetActive(true);

        TweenScale.Begin(this.gameObject, 0.3f, Vector3.one);
    }

    public void CloseWindow()
    {
        TweenScale.Begin(this.gameObject, 0.3f, Vector3.one * 0.01f);
        Invoke("ProcessAfterCloseWindow", 0.3f);
    }
    void ProcessAfterCloseWindow()
    {
        gameObject.SetActive(false);
    }

    public void ClickEndingButton1()
    {
        CloseWindow();
        Application.OpenURL("https://youtu.be/0WQxwSEDBg8");
        Application.LoadLevel("StartScene");
    }

    public void ClickEndingButton2()
    {
        Application.LoadLevel("StartScene");
    }
}
