using UnityEngine;

public class UndeadExecutionerAttackTrigger : AttackTrigger
{
    private BossMovement _parentMovement;

    private void Start()
    {
        _parentMovement = GetComponentInParent<UndeadExecutionerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _parentMovement.triggered = true;
            if (_parentMovement.animator.GetInteger("State") == 0)
                _parentMovement.animator.SetInteger("State", 1);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _parentMovement.triggered = false;
            if (_parentMovement.animator.GetInteger("State") == 1)
                _parentMovement.animator.SetInteger("State", 0);
        }
    }
}
