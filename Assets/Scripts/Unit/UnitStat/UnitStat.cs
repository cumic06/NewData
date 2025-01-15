using UnityEngine;

public interface IUnitStat
{
    public SData<int> health { get; }
    public SData<int> damage { get; }

    public SData<float> moveSpeed { get; }
}