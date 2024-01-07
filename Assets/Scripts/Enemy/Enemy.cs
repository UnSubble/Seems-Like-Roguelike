using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, Damageable
{
    [SerializeField]
    protected PlayerMovement _playerMovement;
    [SerializeField]
    protected float _health;
    [SerializeField]
    protected Animator _animator;
    [SerializeField]
    internal float[] _damageArray;

    public bool IsAlive => _health > 0;

    public abstract void TakeDamage(float damage);
}
