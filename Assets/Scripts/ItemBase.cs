using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using ReusableObjectManagement;

public interface ITransportable
{

}

public class ItemBase : MonoBehaviour, IHasActive
{
    // IHasActiveのプロパティ
    public BoolReactiveProperty isActive { get; set; } = new BoolReactiveProperty(false);
    public IObservable<bool> isActiveObserver => isActive;
    public bool canReuse { get; set; } = false;



}
