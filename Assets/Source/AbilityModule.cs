using UnityEngine;

[CreateAssetMenu(fileName = "AbilityModule", menuName = "Scriptable Objects/AbilityModule")]
public class AbilityModule : ScriptableObject
{



    public virtual AbilityModuleComponent AddModule(GameObject gameObject)
    {
        return gameObject.AddComponent<AbilityModuleComponent>();
    }
}
