using UnityEngine;
using System.Collections;

public class MarkerEventReceiver : MonoBehaviour {
    public static int NumOfMarker = 5;

    public EndingWindowController ewController;

    public UISprite[] Sprite_marker;
    public UISprite[] Sprite_markerInMap;
    
    bool[] markerFlag;


    void Awake()
    {
        markerFlag = new bool[NumOfMarker];
        for (int i = 0; i < NumOfMarker; ++i)
            markerFlag[i] = false;

        Invoke("CheckAllClear", 0.0f);
    }

    void CheckAllClear()
    {
        bool isFinished = true;
        for (int i = 0; i < NumOfMarker; ++i)
        {
            if (!markerFlag[i])
            {
                isFinished = false;
            }
        }

        if (isFinished)
        {
            ewController.OpenWindow();
        }
        else
        {
            Invoke("CheckAllClear", 1.0f);
        }
        
    }
    
    public void OnMarkerFound(ARMarker marker)
    {
        //Debug.Log("found   " + marker.Tag + "  ");
        switch (marker.Tag)
        {
            case "roman1":
                CheckRomanMarker(0);
                break;
            case "roman2":
                CheckRomanMarker(1);
                break;
            case "roman3":
                CheckRomanMarker(2);
                break;
            case "roman4":
                CheckRomanMarker(3);
                break;
            case "roman5":
                CheckRomanMarker(4);
                break;
        }
    }

    public void OnMarkerTracked(ARMarker marker)
    {

        //Debug.Log("tracked   " + marker.Tag + "  ");
    }

    public void OnMarkerLost(ARMarker marker)
    {
        //Debug.Log("lost   " + marker.Tag + "   ");
    }

    void CheckRomanMarker(int markerNum)
    {
        if (!markerFlag[markerNum])
        {
            markerFlag[markerNum] = true;

            Sprite_marker[markerNum].color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
            Sprite_markerInMap[markerNum].color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
        }
        
    }
}
