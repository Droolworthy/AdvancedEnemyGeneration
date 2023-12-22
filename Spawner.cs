using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public Transform[] _target;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private EnemyMover[] _enemies;   
    [SerializeField] private int _delay;

    private Coroutine _coroutine;

    private void Start()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(Play(_delay));
    }

    private IEnumerator Play(int delay)
    {
        bool isWork = true;

        var wait = new WaitForSeconds(delay);

        while (isWork)
        {
            int randomNumber = Random.Range(0, _spawnPoints.Length);

            var enemy = Instantiate(_enemies[randomNumber], _spawnPoints[randomNumber].position, Quaternion.identity);

            enemy.Init(_target);

            yield return wait;
        }
    }
}
