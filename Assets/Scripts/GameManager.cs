using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {  get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;  
    }

    public void DecreaseHealth(Damageable ally, float damage)
    {
        ally.TakeDamage(damage);
        if (ally is PlayerHealthController)
            UIManager.instance.DecreasePlayerHealth(damage);
    }
}
