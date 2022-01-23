using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform levelPart_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        SpawnLevelPart(levelPart_1, new Vector3(0.470337f, 3.995017f, 8.34257f));
        SpawnLevelPart(levelPart_1, new Vector3(0.470337f, 3.995017f, 8.34257f) + new Vector3(0, 0, 15));
        SpawnLevelPart(levelPart_1, new Vector3(0.470337f, 3.995017f, 8.34257f) + new Vector3(0, 0, 15 + 15));
    }
    private void SpawnLevelPart(Transform levelPart_1 ,Vector3 spawnPosition)
    {
        Instantiate(levelPart_1, spawnPosition, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
