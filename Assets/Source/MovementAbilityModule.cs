using UnityEngine;

[CreateAssetMenu(fileName = "MovementAbilityModule", menuName = "Scriptable Objects/MovementAbilityModule")]
public class MovementAbilityModule : AbilityModule
{
    [SerializeField]
    private float _moveSpeed;

    [SerializeField]
    private float _rotationSpeed;



    public float MoveSpeed
    {
        get
        {
            return _moveSpeed;
        }

        private set
        {
            _moveSpeed = value;
        }
    }

    public float RotationSpeed
    {
        get
        {
            return _rotationSpeed;
        }

        private set
        {
            _rotationSpeed = value;
        }
    }



    public override AbilityModuleComponent AddModule(GameObject gameObject)
    {
        return gameObject.AddComponent<MovementAbilityModuleComponent>();
    }
}
