using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetHealth : MonoBehaviour
{
    int hp = 100;
    public void getHp(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
            Destroy(gameObject);
    }
}
