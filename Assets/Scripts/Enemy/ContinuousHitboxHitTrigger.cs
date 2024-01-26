using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousHitboxHitTrigger : MonoBehaviour
{
    [SerializeField]
    int _damageArrayIndex = 0;
    bool _canAttack;

    private void Start()
    {
        _canAttack = true;
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.CompareTag("Player") && _canAttack)
        {
            _canAttack = false;
            StartCoroutine(hit(collider.GetComponent<Damageable>()));
        }

    }

    IEnumerator hit(Damageable damageable)
    {
        GameManager.Instance.DecreaseHealth(damageable, GetComponentInParent<Enemy>()._damageArray[_damageArrayIndex]);
        yield return new WaitForSeconds(GameManager.CONTINUOUS_ATTACK_DELAY);
        _canAttack = true;
    }
}
