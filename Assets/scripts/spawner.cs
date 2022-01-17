using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Transform startPos;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject e = Instantiate(enemy, startPos.position, Quaternion.identity);

        }
    }
}
