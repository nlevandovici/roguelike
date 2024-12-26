using UnityEngine;

public class PlayerComponent : MonoBehaviour
{
    [SerializeField]
    private PlayerParamsComponent _playerParams;

    [SerializeField]
    private AbilityComponent _mainAbility;

    [SerializeField]
    private AbilityComponent _secondaryAbility;

    [SerializeField]
    private AbilityComponent _extraAbility;
}