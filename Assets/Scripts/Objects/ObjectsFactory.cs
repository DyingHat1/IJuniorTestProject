using System.Collections.Generic;
using UnityEngine;

public class ObjectsFactory : MonoBehaviour
{
    public List<LevelObject> CreateLevelObjects(LevelObject template, int count, Transform pool)
    {
        List<LevelObject> objects = new List<LevelObject>();
        
        for (int i = 0; i < count; i++)
        {
            objects.Add(CreateObject(template, pool));
        }

        return objects;
    }

    private LevelObject CreateObject(LevelObject template, Transform pool)
    {
        var levelObject = Instantiate(template, pool);
        levelObject.gameObject.SetActive(false);
        return levelObject;
    }
}
