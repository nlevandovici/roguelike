using UnityEngine;

public class MovementAbilityModuleComponent : AbilityModuleComponent
{
    [SerializeField]
    private MovementAbilityModule _movement;



    public override void Setup(AbilityModule module)
    {
        base.Setup(module);

        _movement = module as MovementAbilityModule;
    }



    private void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * _movement.MoveSpeed * Time.deltaTime, Space.Self);
    }
}
