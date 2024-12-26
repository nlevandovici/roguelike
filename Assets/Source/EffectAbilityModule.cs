using UnityEngine;

[CreateAssetMenu(fileName = "EffectAbilityModule", menuName = "Scriptable Objects/EffectAbilityModule")]
public class EffectAbilityModule : AbilityModule
{
    [SerializeField]
    private float _duration;



    public float Duration
    {
        get
        {
            return _duration;
        }

        private set
        {
            _duration = value;
        }
    }



    public override AbilityModuleComponent AddModule(GameObject gameObject)
    {
        return gameObject.AddComponent<EffectAbilityModuleComponent>();
    }
}