using UnityEngine;
using UniRx;

namespace View
{
    public class UserInput : MonoBehaviour
    {
        public ReactiveProperty<float> horizontal = new ReactiveProperty<float>();
        public ReactiveProperty<float> vertical = new ReactiveProperty<float>();

        void Update()
        {
            horizontal.SetValueAndForceNotify(Input.GetAxis("Horizontal"));
            vertical.SetValueAndForceNotify(Input.GetAxis("Vertical"));
        }
    }
}