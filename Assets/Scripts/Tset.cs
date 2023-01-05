using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Manager;
using ReusableObjectManagement;

public class Tset : MonoBehaviour
{
    [SerializeField] InputManager inputManager;
    [SerializeField] ReusableObjectManager reusableObjectManager;

    private void Start()
    {
        inputManager.Jump
            .Where(key => !key)
            .Subscribe(nouse => Create());
    }

    private void Create()
    {
        reusableObjectManager.CreateOrReuse<ConveyorController>().Init();
    }
}
