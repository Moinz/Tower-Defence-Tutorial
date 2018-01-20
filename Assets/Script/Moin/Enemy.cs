using UnityEngine;

namespace Moin
{
    public abstract class Enemy : MonoBehaviour
    {
        public EnemyInfo Info;
        public abstract void Die();
        public abstract void Spawn();
    }
}
