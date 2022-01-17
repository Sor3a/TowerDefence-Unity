using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerDefenceAi : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float timeToAttack,radious;
    [SerializeField] LayerMask enemyLayer;
    [SerializeField] Transform spawnPos;
    float realTime;

    private void Start()
    {
        realTime = timeToAttack;
    }
    void checkNext()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, radious, enemyLayer);
        if(hit.Length>0)
        {
            GameObject b = Instantiate(bullet, spawnPos.position, Quaternion.identity);
            b.GetComponent<bulletFollowEnemy>().target = hit[0].gameObject;
        }

        
    }
    void Update()
    {
        if (realTime <= 0)
        {
            checkNext();
            realTime = timeToAttack;
        }
        else
            realTime -= Time.deltaTime;
    }
}
