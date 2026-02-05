using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    protected override void Die()
    {
        // Gọi hàm cha
        base.Die();

        Debug.Log("Enemy died");
    }
}