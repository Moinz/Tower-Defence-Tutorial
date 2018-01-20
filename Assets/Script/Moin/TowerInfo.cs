using UnityEngine;

namespace Moin
{
    [CreateAssetMenu(menuName = "Moin/Tower Info")]
    public class TowerInfo : ScriptableObject
    {
        public string Name;
        public string Description;

        [Header("Stats")]
        public int Cost;
        public float Damage;
        public float FireRate;
        public float Range;
    }
}
