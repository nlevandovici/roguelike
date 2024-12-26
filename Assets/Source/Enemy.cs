using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform _player = null;

    [SerializeField]
    private float _speed = 3f;



    private void Update()
    {
        if(_player == null)
        {
            _player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        if (_player == null)
            return;

        transform.position = Vector3.MoveTowards(transform.position, 
            new Vector3(_player.position.x, transform.position.y, _player.position.z), _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}