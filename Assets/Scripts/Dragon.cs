using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Enemy
{
    private void Start()
    {
        AttackPlayer();
    }

    public virtual void AttackPlayer()
    {
        print("Dragon attacks player");
    }
}
