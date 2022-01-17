using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFollowEnemy : MonoBehaviour
{
    public GameObject target;
    [SerializeField] float speed;

    void FixedUpdate()
    {
        if (target != null)
        {
            //transform.right = (target.transform.position - transform.position).normalized;
            float angle = Vector2.SignedAngle(Vector2.up, target.transform.position - transform.position);
            transform.rotation = Quaternion.Euler(0, 0, angle);
            transform.Translate((target.transform.position - transform.position) * speed * Time.deltaTime,Space.World);
            if (Mathf.Abs(Vector2.Distance(transform.position, target.transform.position)) < 1f)
            {
                target.GetComponent<targetHealth>().getHp(40);
                Destroy(gameObject);
            }
        }
        else
            Destroy(gameObject);
        
    }
}
