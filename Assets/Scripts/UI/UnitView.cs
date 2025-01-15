using System;
using UnityEngine;

public abstract class UnitView<T> : DataView<T>, IUnitStat where T : IEquatable<T>
{
    public SData<int> health { get; private set; }
    public SData<int> damage { get; private set; }
    public SData<float> moveSpeed { get; private set; }

    public virtual void Initialize(IUnitStat stat)
    {
        health = stat.health;
        damage = stat.damage;
        moveSpeed = stat.moveSpeed;
    }
}