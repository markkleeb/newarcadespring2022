using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //bullet speed variable
    public float speed = 1f;


    private GameController gcscript;

    // Start is called before the first frame update
    void Start()
    {
        gcscript = GameObject.FindObjectOfType<GameController>();
        Destroy(gameObject, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up* speed* 0.1f, Space.World);
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Invader")
        {
            gcscript.AddScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);

            //Nothing will happen after this point

        }
    }

}
