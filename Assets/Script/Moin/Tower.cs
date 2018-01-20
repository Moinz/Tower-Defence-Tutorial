using UnityEngine;

namespace Moin
{
    public abstract class Tower : MonoBehaviour
    {
        public TowerInfo Info;
        public abstract Tower Purchase();
        public abstract int Sell();
        public abstract void Shoot();
    }
}
