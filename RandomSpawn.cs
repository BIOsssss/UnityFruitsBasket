using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    private float spawnRate = 2f;
    float nextSpawn = 0.0f;

    public List<GameObject> prefabs = new List<GameObject>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-9.13f, 9.5f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            var prefab = prefabs[Random.Range(0, prefabs.Count)];
            Instantiate(prefab, whereToSpawn, Quaternion.identity);
        }
    }
}
