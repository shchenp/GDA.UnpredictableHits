using System.Collections;
using System.Collections.Generic;
using Extensions;
using UnityEngine;

public class RandomAttackAnimation : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger(GlobalConstants.AttackID, Random.Range(0, 2));
    }
}
