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
}
