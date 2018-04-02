using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    public float PanSpeed = 0.05f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ControlCamera();
	}


    private void ControlCamera()
    {
        ////
        //  Standard camera movement moves left-right, Forward-back using world space
        ////
        if ((Input.touchCount > 1 && Input.touchCount < 3) &&
            Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            Debug.Log("touch Delta Pos: " + touchDeltaPosition);
            transform.Translate(-touchDeltaPosition.y * PanSpeed, 0, touchDeltaPosition.x * PanSpeed, Space.World); // control is for x z axis

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -28.0f, 16.0f), Mathf.Clamp(transform.position.y, 1.25f, 8.0f), Mathf.Clamp(transform.position.z, -40.0f, 2.5f));
        }
        // Todo: Mouse drag camera controls (for debuging without mobile device)

        //// TODO:
        //  Cinematic mode (uses local space)
        //  Locks camera to pet, swipe left and right will rotate around point centered on pet.
        //  swiping up-down zooms in and out (within reason)
        ////

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
