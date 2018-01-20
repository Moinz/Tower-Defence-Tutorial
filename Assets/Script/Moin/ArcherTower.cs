using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Moin
{
    public sealed class ArcherTower : Tower
    {
        private SphereCollider _sphereCollider;

        private Transform _target;

        public GameObject Projectile;

        public float Speed;
        public string EnemyTag;

        private float _reloadTime;
        private void Start()
        {
            _sphereCollider = GetComponent<SphereCollider>();

            _sphereCollider.radius = Info.Range;
        }

        private void Update()
        {
            _reloadTime += Time.deltaTime;

            if (_target && _reloadTime > Info.FireRate)
            {
                Shoot();
                _reloadTime = 0;
            }
        }
        public override Tower Purchase()
        {
            throw new System.NotImplementedException();
        }

        public override int Sell()
        {
            throw new System.NotImplementedException();
        }

        public override void Shoot()
        {
            var direction = _target.position - transform.position;
            var projectile = Instantiate(Projectile, transform.position, Quaternion.identity);

            projectile.GetComponent<Rigidbody>().AddForce(direction * Speed);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(EnemyTag))
            {
                Debug.Log("Enemy entered");
                _target = other.transform;
            }
        }
    }
}
