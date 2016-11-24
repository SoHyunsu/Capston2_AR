using UnityEngine;
using System.Collections;

public class StartSceneManager : MonoBehaviour {

    public SelectionWindowController swController;


    public void ClickClass1()
    {
        //Debug.Log("click 1");
        swController.OpenWindow();
    }

}
