using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Scriptable Objects/Ability")]
public class Ability : ScriptableObject
{
    [SerializeField]
    private string _name = "Ability";

    [SerializeField]
    private AbilityModule[] _modules = new AbilityModule[3];

    [SerializeField]
    private float _duration;

    [SerializeField]
    private float _recharge;



    public string Name
    {
        get
        {
            return _name;
        }

        private set
        {
            _name = value;
        }
    }

    public AbilityModule[] Modules
    {
        get
        {
            return _modules;
        }

        private set
        {
            _modules = value;
        }
    }

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

    public float Recharge
    {
        get
        {
            return _recharge;
        }

        private set
        {
            _recharge = value;
        }
    }



    public virtual AbilityComponent AddAbility(GameObject gameObject)
    {
        return gameObject.AddComponent<AbilityComponent>();
    }

    public virtual AbilityModuleComponent[] AddModules(GameObject gameObject)
    {
        AbilityModuleComponent[] modules = new AbilityModuleComponent[_modules.Length];

        for(int i = 0; i < _modules.Length; i++)
        {
            modules[i] = _modules[i].AddModule(gameObject);

            modules[i].Setup(_modules[i]);
        }

        return modules;
    }
}