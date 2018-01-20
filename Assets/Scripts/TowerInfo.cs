using UnityEngine;

namespace TowerDefence
{
    /*
     * TowerInfo is the information that basically all our Towers will have, and instead of having to write these variables on every Tower Class
     * we have instead made the info a Class, so that its quicker and easier for us to use the information
     * 
     * Inheriting from ScriptableObjects lets us save data on disk, which is very handy for several reasons.
     * One of the best reasons is that we can always have a reference to a ScriptableObject and it will cause less Reference issues in the future!
     * https://docs.unity3d.com/ScriptReference/ScriptableObject.html
     * 
     * The CreateAssetMenu attribute lets us use the Asset Menu to create our assets, which is very handy.
     * https://docs.unity3d.com/ScriptReference/CreateAssetMenuAttribute.html
     */
    [CreateAssetMenu(menuName = "Moin/Tower Info")]
    public class TowerInfo : ScriptableObject
    {
        public string Name;
        public string Description;

        [Header("Stats")]
        public int Cost;
        public int Damage;
        public float Range;
        public float FireRate;
    }
}

