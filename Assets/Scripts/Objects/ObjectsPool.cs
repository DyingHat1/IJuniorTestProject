using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectsPool : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;

    private List<LevelObject> _objects;

    public void Init(List<LevelObject> objects)
    {
        _objects = objects;
    }

    public void Spawn()
    {
        LevelObject levelObject = _objects.First(p => p.gameObject.activeInHierarchy == false);
        levelObject.transform.position = _spawnPoint.transform.position;
        levelObject.gameObject.SetActive(true);
    }
}
