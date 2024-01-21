using UnityEngine;

namespace Extensions
{
    public static class GlobalConstants
    {
        public static readonly int Speed = Animator.StringToHash("speed");
        public static readonly int Attack = Animator.StringToHash("attack");
        public static readonly int AttackID = Animator.StringToHash("attackID");
    }
}