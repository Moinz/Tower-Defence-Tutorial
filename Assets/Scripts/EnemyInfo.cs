using UnityEngine;

namespace TowerDefence
{
    /*
     * This is all the Information that our Enemies will have.
     * See TowerInfo.cs for more.
     */
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

