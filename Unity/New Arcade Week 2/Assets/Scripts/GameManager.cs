using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < 5; i++)
        {

            Instantiate(coin, new Vector3(Random.Range(-10f, 10f),
                Random.Range(-5f, 5f), 0), Quaternion.identity);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
