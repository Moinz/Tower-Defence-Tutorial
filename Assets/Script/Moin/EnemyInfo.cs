using UnityEngine;

namespace Moin
{
    [CreateAssetMenu(menuName = "Moin/Enemy Info")]
    public class EnemyInfo : ScriptableObject
    {
        public string Name;
        public string Description;

        [Header("Stats")]
        public float Speed;
        public int Health;
        public int Reward;
    }
}
