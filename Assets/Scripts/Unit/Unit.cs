using UnityEngine;
using UnityEngine.XR;

public class Unit : MonoBehaviour, IUnitStat
{
    [field: SerializeField] public SData<int> health { get; set; }
    [field: SerializeField] public SData<int> damage { get; set; }
    [field: SerializeField] public SData<float> moveSpeed { get; set; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            UIManager.Instance.ShowUnitView(this);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            health.Value -= 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            damage.Value += 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            health.Value = health.Value;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            damage.Value = damage.Value;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            health.Value += 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            damage.Value += 0;
        }
    }
}