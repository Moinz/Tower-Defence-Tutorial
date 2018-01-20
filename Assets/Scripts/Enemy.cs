using UnityEngine;

namespace TowerDefence
{
    /*
    * This is the recipe for every Enemy class that we will make in this project. 
    * See Tower.cs for more information
    */
    public abstract class Enemy : MonoBehaviour
    {
        public EnemyInfo Info;

        public abstract void Die();
        public abstract void Spawn();       
    }
}
