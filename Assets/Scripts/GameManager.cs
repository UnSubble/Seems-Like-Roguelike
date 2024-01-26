using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {  get; private set; }
    public static readonly float CONTINUOUS_ATTACK_DELAY = 0.2f;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;  
    }

    public void DecreaseHealth(Damageable ally, float damage)
    {
        ally.TakeDamage(damage);
        if (ally is PlayerHealthController)
            UIManager.instance.DecreasePlayerHealth(damage);
    }
}
