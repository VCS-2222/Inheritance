using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Orc : Enemy
{
    private void Start()
    {
        AttackPlayer();
    }
    
    public override void AttackPlayer()
    {
        base.AttackPlayer();
        print("Orc attacks player");
    }
}