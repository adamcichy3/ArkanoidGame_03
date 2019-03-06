using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

    [SerializeField] float ScreenWidhtInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
   
	
	// Update is called once per frame
	void Update ()
    {
        float MousePosInUnits =  Input.mousePosition.x / Screen.width * ScreenWidhtInUnits;
        Vector2 PaddlePos = new Vector2(transform.position.x, transform.position.y);
        PaddlePos.x = Mathf.Clamp(MousePosInUnits, minX, maxX);
        transform.position = PaddlePos;  
	}
}
