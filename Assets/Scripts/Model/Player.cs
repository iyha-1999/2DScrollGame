using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Model
{
    public class Player
    {
        public ReactiveProperty<Vector3> force = new ReactiveProperty<Vector3>();
        public ReactiveProperty<float> forceSpeed = new ReactiveProperty<float>(50);

        public void SetForce(Vector3 vector3)
        {
            force.Value = vector3 * forceSpeed.Value;
        }
    }
}

