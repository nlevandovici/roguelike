using UnityEngine;

[CreateAssetMenu(fileName = "AreaDamageAbilityModule", menuName = "Scriptable Objects/AreaDamageAbilityModule")]
public class AreaDamageAbilityModule : AbilityModule
{
    public override AbilityModuleComponent AddModule(GameObject gameObject)
    {
        return gameObject.AddComponent<AreaDamageAbilityModuleComponent>();
    }
}
