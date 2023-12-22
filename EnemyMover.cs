using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform[] _target;
    private int _spawnPointNumber;

    private void Start()
    {
        _spawnPointNumber = Random.Range(0, _target.Length);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target[_spawnPointNumber].position, _speed * Time.deltaTime);
    }

    public void Init(Transform[] target)
    {
        _target = target;
    }
}
