using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
        //{            
        //    MovePaddle(-1);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
        //{
        //    MovePaddle(1);
        //}

        float mouseSpeed = Input.GetAxis("Mouse X") * speed;
        transform.Translate(mouseSpeed, 0, 0);
    }

    void MovePaddle(int direction) 
    {
        //switch (direction)
        //{
        //    case 1:
        //        //move right
        //        transform.Translate(Vector3.right * speed * Time.deltaTime);
        //        break;
        //    case -1:
        //        // move left
        //        transform.Translate(Vector3.left * speed * Time.deltaTime);
        //        break;
        //    default:
        //        break;
        //}
    }
}
