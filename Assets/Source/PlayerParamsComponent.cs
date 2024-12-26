using UnityEngine;

public class PlayerParamsComponent : MonoBehaviour
{
    [SerializeField]
    private float _health = 0f;

    [SerializeField]
    private float _speed = 0f;

    [SerializeField]
    private float _mana = 0f;

    [SerializeField]
    private float _energy = 0f;



    public float Health
    {
        get
        {
            return _health;
        }

        private set
        {
            _health = value;
        }
    }

    public float Speed
    {
        get
        {
            return _speed;
        }

        private set
        {
            _speed = value;
        }
    }

    public float Mana
    {
        get
        {
            return _mana;
        }

        private set
        {
            _mana = value;
        }
    }

    public float Energy
    {
        get
        {
            return _energy;
        }

        private set
        {
            _energy = value;
        }
    }



    public void Damage(float health)
    {
        Health -= health;
    }

    public void Heal(float health)
    {
        Health += health;
    }

    public void ChangeSpeed(float speed)
    {
        Speed = speed;
    }

    public void UseMana(float mana)
    {
        Mana -= mana;
    }

    public void AddMana(float mana)
    {
        Mana += mana;
    }

    public void UseEnergy(float energy)
    {
        Energy -= energy;
    }

    public void AddEnergy(float energy)
    {
        Energy += energy;
    }
}