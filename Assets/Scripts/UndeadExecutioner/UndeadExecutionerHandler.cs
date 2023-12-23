
using UnityEngine;

public class UndeadExecutionerHandler : EnemyBoss
{
    [SerializeField]
    private int _reloadSummonTime;
    [SerializeField]
    private float _playerDistanceForSkill;
    private UndeadExecutionerMovement _movement;
    private int _timer;

    public override void TakeDamage(float damage)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        _movement = GetComponent<UndeadExecutionerMovement>();
        _timer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_timer < _reloadSummonTime)
            _timer++;
        else if (Vector3.Distance(_playerMovement.transform.position, transform.position) > _playerDistanceForSkill)
        {
            _animator.Play("Skill");
            _timer = 0;
            _movement.triggered = true;
        }
    }

    public void InterruptAttackAnimation()
    {
        if (_movement.animator.GetInteger("State") == 0)
            _movement.animator.Play("Idle");
    }

    public void SummonSouls()
    {
        _movement.triggered = false;
        Debug.Log("Summoned");
    }
}
