using UnityEngine;

[CreateAssetMenu(fileName = "SoundAbilityModule", menuName = "Scriptable Objects/SoundAbilityModule")]
public class SoundAbilityModule : AbilityModule
{
    public override AbilityModuleComponent AddModule(GameObject gameObject)
    {
        return gameObject.AddComponent<SoundAbilityModuleComponent>();
    }
}
