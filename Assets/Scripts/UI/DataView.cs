using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class DataView<T> : MonoBehaviour where T : IEquatable<T>
{
    protected List<SData<T>> datas = new();
    protected Action disposer;

    protected virtual void OnEnable()
    {
        if (datas.Count == 0) return;

        foreach (var data in datas)
        {
            if (data == null) continue;
            data.Registor(UpdateView, disposer);
            UpdateView(data.Value);
        }
    }

    protected virtual void OnDisable()
    {
        disposer?.Invoke();
    }

    protected virtual void UpdateView(T data)
    {
        
    }
}