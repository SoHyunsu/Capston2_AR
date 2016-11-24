using UnityEngine;
using System.Collections;

public class ScenarioManager : MonoBehaviour {

    static ScenarioManager _instance;
    public static ScenarioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject obj = GameObject.Find("ScenarioManager");
                if (obj == null)
                {
                    Debug.LogWarning("'ScenarioManager' GameObject could not be found in the scene.");
                }
                else
                {
                    _instance = obj.GetComponent<ScenarioManager>();
                }
            }
            return _instance;
        }
    }


    public GameObject OpenMapButton;
    public GameObject BackToCameraButton;

    public GameObject MapSprite;

    public GameObject CheckUIs;


    bool isOpenMap = false;

	// Use this for initialization
	void Start () {
        isOpenMap = true;
        OpenMapButton.SetActive(false);
        BackToCameraButton.SetActive(true);

        CheckUIs.SetActive(false);

        MapSprite.SetActive(true);
	}


    public void ClickOpenMapButton()
    {
        isOpenMap = true;
        OpenMapButton.SetActive(false);
        BackToCameraButton.SetActive(true);

        CheckUIs.SetActive(false);

        MapSprite.SetActive(true);
    }

    public void ClickBackToCameraButton()
    {
        isOpenMap = false;
        OpenMapButton.SetActive(true);
        BackToCameraButton.SetActive(false);

        CheckUIs.SetActive(true);

        MapSprite.SetActive(false);
    }
}
