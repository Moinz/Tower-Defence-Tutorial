using UnityEngine;

namespace TowerDefence // Our own namespace
{
    /*
     * This class is basically a recipe for our other Tower classes, so that we can reference these elements when dealing with all the 
     * different kinds of Tower Classes that we will potentially make. 
     * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
     */
    public abstract class Tower : MonoBehaviour
    {
        /*
         * Every Tower needs some information on itself, which is why we referenced TowerInfo
         * so that we can get all the information we need
         */
        public TowerInfo Info;

        /*
         * These are functions that we haven't implemented yet, and we can't implement them in this class
         * as abstract classes are merely templates for our other classes to use. 
         */
        public abstract Tower Purchase();
        public abstract int Sell();
        public abstract void Shoot();
    }
}
