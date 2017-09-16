using UnityEngine;

namespace Parcial2.Game
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]
    public class ExplosiveBullet : MonoBehaviour
    {
        private Rigidbody myRigidBody;
        private float speed;
        private int damage;

        [SerializeField]
        private GameObject instigator;

        public void SetParams(float bulletSpeed, int bulletDamage, GameObject instanceInstigator)
        {
            instigator = instanceInstigator;
            speed = bulletSpeed;
            damage = bulletDamage;
        }

        public void Toss()
        {
            myRigidBody.AddForce(transform.forward * speed, ForceMode.VelocityChange);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject == Player.Instance.gameObject)
            {
                //Collided with player
            }
            else
            {
                Enemy enemy = other.GetComponent<Enemy>();

                if (enemy != null)
                {
                    Estallar();
                }
            }

            if (instigator != other.gameObject)
            {
                Destroy(gameObject); 
            }
        }

        // Use this for initialization
        private void Awake()
        {
            myRigidBody = GetComponent<Rigidbody>();
        }

        private void OnDestroy()
        {
            myRigidBody = null;
        }

        private void Estallar()
        {
            Collider[] otherColliders = Physics.OverlapSphere(transform.position, 10F);

            for (int i = 0; i < otherColliders.Length; i++)
            {
                {
                    Enemy enemy = otherColliders[i].GetComponent<Enemy>();

                    if (enemy != null)
                    {
                        enemy.ReceiveDamage(damage);
                    }
                }
            }
        }
    } 
}