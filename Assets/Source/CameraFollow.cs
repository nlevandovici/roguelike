using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform _player;

    [SerializeField]
    private Vector3 _offset = new Vector3(0f, 5f, -5f);



    private void Update()
    {
        transform.position = _player.position + _offset;
    }
}