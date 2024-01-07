using UnityEngine;

public class UndeadExecutionerMovement : BossMovement
{ 

    bool GetAttackingEnd()
    {
        return animator.GetInteger("State") == 0;
    }

    void FixedUpdate()
    {
        if (GetAttackingEnd())
        {
            if (!triggered)
            {
                FollowPlayer();
            }
            else
            {
                Rigidbody.velocity = Vector3.zero;
            }
            RotatePlayer();
        }
        else
        {
            Rigidbody.velocity = Vector3.zero;
        }
    }
}
