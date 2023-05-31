using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawner : MonoBehaviour
{
    [SerializeField] private List<ObjectsPool> _pools;
    [SerializeField] private int _maxObjectsCountInARow;
    [SerializeField] private float _maxWaitTime;
    [SerializeField] private float _minWaitTime;
    [SerializeField] private float _secondsBetweenObjectsSpawn;

    private WaitForSeconds _waitForSeconds;
    private float _elapsedTime;
    private bool _isCoroutineOn = false;

    private void Update()
    {
        if (_elapsedTime <= 0)
        {
            if (_isCoroutineOn == false)
            {
                StartCoroutine(Spawn(Random.Range(1, _maxObjectsCountInARow + 1), _pools[Random.Range(0, _pools.Count)]));
                _elapsedTime = Random.Range(_minWaitTime, _maxWaitTime);
            }
        }

        _elapsedTime -= Time.deltaTime;
    }

    public void Init()
    {
        _waitForSeconds = new WaitForSeconds(_secondsBetweenObjectsSpawn);
        _elapsedTime = _maxWaitTime;
        enabled = true;
    }

    private IEnumerator Spawn(int count, ObjectsPool pool)
    {
        _isCoroutineOn = true;

        for (int i = 0; i < count; i++)
        {
            pool.Spawn();
            yield return _waitForSeconds;
        }

        _isCoroutineOn = false;
    }
}
