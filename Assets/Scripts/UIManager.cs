using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _playerHealth;
    public static UIManager instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void DecreasePlayerHealth(float damage)
    {
        float currentHealth = Convert.ToSingle(_playerHealth.text);
        if (currentHealth <= 0)
        {
            
        }
        _playerHealth.text = Convert.ToString(currentHealth - damage);
    }
}
