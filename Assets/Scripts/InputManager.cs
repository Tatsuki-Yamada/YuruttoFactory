using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ReusableObjectManagement;

namespace Manager
{
    public class InputManager : MonoBehaviour
    {
        private readonly BoolReactiveProperty jumpProperty = new BoolReactiveProperty();

        public IReadOnlyReactiveProperty<bool> Jump => jumpProperty;


        private void Start()
        {
            jumpProperty.AddTo(this);
        }

        private void Update()
        {
            jumpProperty.Value = Input.GetButton("Jump");
        }
    }
}