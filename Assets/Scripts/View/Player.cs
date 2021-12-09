using UnityEngine;

namespace View
{
    public class Player : MonoBehaviour
    {
        Rigidbody _rigidbody;

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void SerForce(Vector3 force)
        {
            _rigidbody.AddForce(force);
        }
    }
}
