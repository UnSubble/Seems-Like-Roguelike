using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndeadExecutionerHitboxTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.DecreaseHealth(collision.GetComponent<Damageable>(), 10);
        }
    }
}
