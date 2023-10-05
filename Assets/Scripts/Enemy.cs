using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyStrength;

    public virtual void AttackPlayer()
    {
        print("Enemy attacks player");
    }
}
