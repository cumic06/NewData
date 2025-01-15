using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    private UnitViewInt _unitViewInt;
    private UnitViewFloat _unitViewFloat;

    private void Awake()
    {
        Instance = this;
        _unitViewInt = GetComponentInChildren<UnitViewInt>(true);
        _unitViewFloat = GetComponentInChildren<UnitViewFloat>(true);
    }

    public void ShowUnitView(IUnitStat unitStat)
    {
        _unitViewInt.gameObject.SetActive(!_unitViewInt.gameObject.activeSelf);
        _unitViewInt.Initialize(unitStat);
        _unitViewFloat.Initialize(unitStat);
    }
}