using UnityEngine;

public class AbilityModuleComponent : MonoBehaviour
{
    [SerializeField]
    protected AbilityModule _module;



    public virtual void Setup(AbilityModule module)
    {
        _module = module;
    }
}
