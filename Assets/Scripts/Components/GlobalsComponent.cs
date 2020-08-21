using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public struct GlobalsComponent : ISharedComponentData, IEquatable<GlobalsComponent>
{
    public ScriptableObject _data;
    
    public bool Equals(GlobalsComponent other)
    {
        return _data == other._data;
    }

    public override int GetHashCode()
    {
        return _data.GetHashCode();
    }
}
