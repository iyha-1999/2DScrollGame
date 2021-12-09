using UnityEngine;
using UniRx;

namespace Model
{
    public class UserInput
    {
        public ReactiveProperty<float> horizontal = new ReactiveProperty<float>();
        public ReactiveProperty<float> vertical = new ReactiveProperty<float>();

        public Vector3 GetVector3FromAxis()
        {
            return new Vector3(horizontal.Value, 0, vertical.Value);
        }
    }
}
