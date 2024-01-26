using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxHitTrigger : MonoBehaviour
{
    [SerializeField]
    private int _damageArrayIndex = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.DecreaseHealth(collision.GetComponent<Damageable>(), GetComponentInParent<Enemy>()._damageArray[_damageArrayIndex]);
        }
    }
}
