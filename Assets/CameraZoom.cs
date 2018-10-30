using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

	float curZoomPos, zoomTo;
    float zoomFrom = 2000f;


    void Update()
    {
        float y = Input.mouseScrollDelta.y;
        if (y >= 1)
        {
            zoomTo -= 500f;
            Debug.Log("Zoomed In");
        }
        else if (y >= -1)
        {
            zoomTo += 500f;
            Debug.Log("Zoomed Out");
        }
        curZoomPos = zoomFrom + zoomTo;

        curZoomPos = Mathf.Clamp(curZoomPos, 5000f, 3500f);
        zoomTo = Mathf.Clamp(zoomTo, -1500f, 3000f);

        Camera.main.fieldOfView = curZoomPos;
    }
}
