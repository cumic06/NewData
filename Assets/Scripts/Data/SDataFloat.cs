using UnityEngine;

[CreateAssetMenu(fileName = "SDataFloat", menuName = "Data/SData/Float")]
public class SDataFloat : SData<float>
{
    public override float Value
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
        var currentValue = (float)current;
        var maxValue = (float)max;

        return currentValue > maxValue;
    }

    protected override bool IsMin(object current, object min)
    {
        var currentValue = (float)current;
        var minValue = (float)min;
        return currentValue < minValue;
    }
}