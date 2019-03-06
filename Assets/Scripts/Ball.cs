using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] PaddleMovement paddle1;
    Vector2 paddleToBallVector;
    [SerializeField] Rigidbody2D rb;
    bool hasStarted = false;

    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        // Różnica(Offset) = Pozycja piłki - pozycja platformy
        rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            rb.simulated = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
        }
    }

    void Update()
    {
       
        if (!hasStarted )
        {
            LaunchOnMouseClick();
            LockBallToPaddle();
        }
 
    }

   

    private void LockBallToPaddle()
    { 
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
        // Pozycja piłki = pozycja platformy + offset
    }


}
