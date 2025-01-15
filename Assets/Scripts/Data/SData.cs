using System;
using UnityEngine;

public class SData<T> : ScriptableObject where T : IEquatable<T>
{
    [SerializeField] protected T maxValue;
    [SerializeField] protected T minValue;
    [SerializeField] protected T startValue;

    protected T currentValue;

    protected Action<T> onChangeValue;

    private void OnEnable()
    {
        currentValue = startValue;
    }

    public virtual T Value
    {
        get => currentValue;
        set
        {
            if ((value != null || currentValue != null) && currentValue.Equals(value)) return;
            currentValue = value;
            onChangeValue?.Invoke(currentValue);
        }
    }

    protected virtual bool IsMax(object current, object max)
    {
        return false;
    }

    protected virtual bool IsMin(object current, object min)
    {
        return false;
    }

    public virtual void Registor(Action<T> onChange, Action disposer)
    {
        onChangeValue += onChange;
        disposer += () => onChangeValue -= onChange;
    }
}