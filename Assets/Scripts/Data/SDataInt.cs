using UnityEngine;

[CreateAssetMenu(fileName = "SDataInt", menuName = "Data/SData/Int")]
public class SDataInt : SData<int>
{
    public override int Value
    {
        get => currentValue;
        set
        {
            if (IsMax(value, maxValue) && maxValue != -1) return; //최댓값 초과이거나 최댓값이 정해져있다면 
            if (IsMin(value, minValue) && minValue != -1) return; //최솟값 미만이거나 최솟값이 정해져있다면
            base.Value = value;
        }
    }

    protected override bool IsMax(object current, object max)
    {
        var currentValue = (int)current;
        var maxValue = (int)max;

        return currentValue > maxValue;
    }

    protected override bool IsMin(object current, object min)
    {
        var currentValue = (int)current;
        var minValue = (int)min;
        return currentValue < minValue;
    }
}