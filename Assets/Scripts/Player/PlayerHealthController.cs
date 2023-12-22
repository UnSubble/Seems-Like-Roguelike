using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour, Damageable
{
    [SerializeField]
    private float _health;
    public bool IsAlive => _health > 0;

    public void TakeDamage(float damage)
    {
        _health = damage;
        if (!IsAlive)
            gameObject.SetActive(false);
    }
}
