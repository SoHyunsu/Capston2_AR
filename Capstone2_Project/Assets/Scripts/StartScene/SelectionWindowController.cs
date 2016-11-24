using UnityEngine;
using System.Collections;

public class SelectionWindowController : MonoBehaviour {

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


    public void ClickOKButton()
    {
        Application.LoadLevel("ARCameraScene");
    }
}
