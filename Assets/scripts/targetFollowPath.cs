using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetFollowPath : MonoBehaviour
{
    Transform path;
    [SerializeField] float speed;
    int number = 0;

    private void Awake()
    {
        path = FindObjectOfType<spawner>().transform;
    }

    private void Update()
    {

        if (number < path.childCount)
        {
            Transform target = path.GetChild(number);
            if (Mathf.Abs(Vector2.Distance(target.position, transform.position)) < 0.5f)
                number++;
            else
                transform.Translate((target.position - transform.position).normalized * speed * Time.deltaTime);
        }
        else
            Destroy(gameObject);
    }
}
