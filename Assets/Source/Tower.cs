using System.Collections;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;

    [SerializeField]
    private float _delay = 4f;

    [SerializeField]
    private int _count = 5;



    private void Awake()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(_count > 0)
        {
            yield return new WaitForSeconds(_delay);

            _count--;

            Instantiate(_prefab, transform.position, Quaternion.identity);
        }
    }
}
