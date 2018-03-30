using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    public float PanSpeed = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ControlCamera();
	}

    private void ControlCamera()
    {
        if ((Input.touchCount > 1 && Input.touchCount < 3) &&
            Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-touchDeltaPosition.x * PanSpeed, -touchDeltaPosition.y * PanSpeed, 0); // control is for x z axis
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("down key pressed");
            transform.Translate(0.0f, -PanSpeed * 2, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up key pressed");
            transform.Translate(0.0f, PanSpeed * 2, 0.0f);
        }
    }
}
