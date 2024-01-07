public interface Damageable
{
    bool IsAlive { get; }
    void TakeDamage(float damage);
}
