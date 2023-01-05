using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ReusableObjectManagement;

public class ConveyorController : MonoBehaviour, IHasActive
{
    Coroutine disableCoroutine;
    public BoolReactiveProperty isActive { get; set; } = new BoolReactiveProperty(false);
    public IObservable<bool> isActiveObserver => isActive;
    public bool canReuse { get; set; } = false;


    public void Init()
    {
        isActive.Value = true;
        canReuse = true;

    }


    private void Disable()
    {
        isActive.Value = false;

    }



}
