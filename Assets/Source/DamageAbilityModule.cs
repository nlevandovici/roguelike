using UnityEngine;

[CreateAssetMenu(fileName = "DamageAbilityModule", menuName = "Scriptable Objects/DamageAbilityModule")]
public class DamageAbilityModule : AbilityModule
{
    public override AbilityModuleComponent AddModule(GameObject gameObject)
    {
        return gameObject.AddComponent<DamageAbilityModuleComponent>();
    }
}
