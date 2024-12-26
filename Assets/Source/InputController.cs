using UnityEngine;

public static class InputController
{
    public static bool MainAbility
    {
        get
        {
            return Input.GetKey(KeyCode.Alpha1);
        }
    }

    public static bool SecondaryAbility
    {
        get
        {
            return Input.GetKey(KeyCode.Alpha2);
        }
    }

    public static bool ExtraAbility
    {
        get
        {
            return Input.GetKey(KeyCode.Alpha3);
        }
    }

    public static bool Attack
    {
        get
        {
            return Input.GetKey(KeyCode.Space);
        }
    }
}
