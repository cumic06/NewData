using TMPro;
using UnityEngine;

public class UnitViewInt : UnitView<int>
{
    [SerializeField] private string healthName;
    [SerializeField] private string damageName;

    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI damageText;

    public override void Initialize(IUnitStat stat)
    {
        base.Initialize(stat);
        UpdateHealth(health.Value);
        UpdateDamage(damage.Value);
        health.Registor(UpdateHealth, disposer);
        damage.Registor(UpdateDamage, disposer);
    }

    private void UpdateHealth(int value)
    {
        SetText(healthText, healthName, value);
    }

    private void UpdateDamage(int value)
    {
        SetText(damageText, damageName, value);
    }

    private void SetText(TextMeshProUGUI text, string name, int value)
    {
        text.SetText($"{name}{value}");
    }
}