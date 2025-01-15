using TMPro;
using UnityEngine;

public class UnitViewFloat : UnitView<float>
{
    [SerializeField] private string moveSpeedName;

    [SerializeField] private TextMeshProUGUI moveSpeedText;

    public override void Initialize(IUnitStat stat)
    {
        base.Initialize(stat);
        UpdateMoveSpeed(moveSpeed.Value);
        moveSpeed.Registor(UpdateMoveSpeed, disposer);
    }

    private void UpdateMoveSpeed(float data)
    {
        
    }
}