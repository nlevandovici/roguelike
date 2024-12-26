using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Scriptable Objects/Player")]
public class Player : ScriptableObject
{
    [SerializeField]
    private PlayerParams _playerParams;

    [SerializeField]
    private Ability _mainAbility;

    [SerializeField]
    private Ability _secondaryAbility;

    [SerializeField]
    private Ability _extraAbility;



    public PlayerParamsComponent AddPlayerParams(GameObject gameObject)
    {
        PlayerParamsComponent playerParams = gameObject.AddComponent<PlayerParamsComponent>();

        playerParams.Setup(_playerParams);

        return playerParams;
    }

    public AbilityComponent AddMainAbility(GameObject gameObject)
    {
        AbilityComponent ability = _mainAbility.AddAbility(gameObject);

        ability.Setup(_mainAbility, _mainAbility.AddModules(gameObject));

        return ability;
    }

    public AbilityComponent AddSecondaryAbility(GameObject gameObject)
    {
        AbilityComponent ability = _secondaryAbility.AddAbility(gameObject);

        ability.Setup(_secondaryAbility, _secondaryAbility.AddModules(gameObject));

        return ability;
    }

    public AbilityComponent AddExtraAbility(GameObject gameObject)
    {
        AbilityComponent ability = _extraAbility.AddAbility(gameObject);

        ability.Setup(_extraAbility, _extraAbility.AddModules(gameObject));

        return ability;
    }
}
