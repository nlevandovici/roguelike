using UnityEngine;

public class AbilityComponent : MonoBehaviour
{
    [SerializeField]
    private Ability _ability;

    [SerializeField]
    private AbilityModuleComponent[] _modules;



    public void Setup(Ability ability, AbilityModuleComponent[] modules)
    {
        _ability = ability;

        _modules = modules;
    }

    public void Activate()
    {
        SetActive(true);
    }

    public void Deactivate()
    {
        SetActive(false);
    }

    private void SetActive(bool active)
    {
        enabled = active;

        for(int i = 0; i < _modules.Length; i++)
        {
            _modules[i].enabled = active;
        }
    }
}