using UnityEngine;

[CreateAssetMenu(fileName = "AnimationAbilityModule", menuName = "Scriptable Objects/AnimationAbilityModule")]
public class AnimationAbilityModule : AbilityModule
{
    public override AbilityModuleComponent AddModule(GameObject gameObject)
    {
        return gameObject.AddComponent<AnimationAbilityModuleComponent>();
    }
}
