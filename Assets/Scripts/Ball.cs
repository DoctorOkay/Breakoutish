using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //config params
    [SerializeField] Paddle paddle1;
    [SerializeField] float launchVectorX = 2f;
    [SerializeField] float launchVectorY = 10f;

    //state
    Vector2 paddleToBallVector;
    bool isLaunched;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        isLaunched = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLaunched)
        {
            LockBallToPaddle();
        }
        
        LaunchOnMouseClick();
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(launchVectorX, launchVectorY);
            isLaunched = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
