using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KirbyScript : MonoBehaviour
{

    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode jump;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKey(moveLeft))
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Debug.Log("pressing left");

            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        //if (Input.GetKey(moveRight))
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(jump))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

    }
}
