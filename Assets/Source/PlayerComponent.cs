using UnityEngine;

public class PlayerComponent : MonoBehaviour
{
    [SerializeField]
    private Player _player;

    [SerializeField]
    private PlayerParamsComponent _playerParams;

    [SerializeField]
    private AbilityComponent _mainAbility;

    [SerializeField]
    private AbilityComponent _secondaryAbility;

    [SerializeField]
    private AbilityComponent _extraAbility;



    private void Awake()
    {
        _playerParams = _player.AddPlayerParams(gameObject);

        _mainAbility = _player.AddMainAbility(gameObject);

        _secondaryAbility = _player.AddSecondaryAbility(gameObject);

        _extraAbility = _player.AddExtraAbility(gameObject);

        _mainAbility.Activate();

        _secondaryAbility.Deactivate();

        _extraAbility.Deactivate();
    }
}