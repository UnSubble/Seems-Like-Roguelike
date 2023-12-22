using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Damageable
{
    bool IsAlive { get; }
    void TakeDamage(float damage);
}
