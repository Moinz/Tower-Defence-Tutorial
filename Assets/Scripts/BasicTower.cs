using UnityEngine;

namespace TowerDefence
{
    /*
     * This is the basic implementation of Tower.cs. Visual Studio will not compile this class
     * unless we have implemented all the Functions that we declared in Tower.cs, and also provides
     * an auto-complete function for this. 
     * 
     * We have sealed this class for increased performance, as currently we are not gonna inherit
     * anything from this class.
     * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
     */
    public sealed class BasicTower : Tower
    {
        private SphereCollider _sphereCollider; // The Sphere collider allows us to check for gameObjects within a spherical area

        public string EnemyTag; // The Tag of the Enemy
        public GameObject Projectile; // Projectile Prefab
        public float Speed; // Projectile Speed

        private Transform _targetTransform; // The current target that we are shooting at.
        private float _reloadTime; // The time since we last shot
        private void Start()
        {
            _sphereCollider = GetComponent<SphereCollider>(); // Getting the reference to the SphereCollider component
            _sphereCollider.radius = Info.Range; // Here we are using the TowerInfo that we inherited from Tower to define the radius of the sphere collider
        }

        private void Update()
        {
            _reloadTime += Time.deltaTime; // Adding "Seconds since last frame" to _reloadTime

            if (_targetTransform && _reloadTime > Info.FireRate) // If we have a reference to a Target AND reload time is more than the FireRate variable in TowerInfo
            {
                Shoot(); // Call the Shoot function! 
                _reloadTime = 0; // Reset _reloadTime!
            }
        }
        /*
         * Unity Function that is called when we encounter a trigger collision
         * https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
         */
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(EnemyTag))
            {
                _targetTransform = other.transform;
            }
        }

        /*
         * Unity Function that is called when a trigger collider leaves our range
         * https://docs.unity3d.com/ScriptReference/Collider.OnTriggerExit.html
         */
        private void OnTriggerExit(Collider other)
        {
            if (other.transform == _targetTransform.transform)
            {
                _targetTransform = null;
            }
        }

        /*
         * Unimplemented Purchase Function
         */
        public override Tower Purchase()
        {
            throw new System.NotImplementedException();
        }

        /*
         * Unimplemented Sell Function
         */
        public override int Sell()
        {
            throw new System.NotImplementedException();
        }


        public override void Shoot()
        {
            var direction = (_targetTransform.position - transform.position).normalized; // Gets the Directional Vector
            var projectile = Instantiate(Projectile, transform.position, Quaternion.identity); // Instantiate a projectile at our position

            projectile.GetComponent<Rigidbody>().AddForce(direction * Speed); // Add force to the projectile in the direction of our target. 
        }
    }
}
