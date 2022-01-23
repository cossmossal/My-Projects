using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneratorScript : MonoBehaviour
{
    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private List<Transform> levelPartList;
   // [SerializeField] private Player player;
    private Vector3 lastEndPosition;
    GameObject player;
   
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200F;
    private void Awake()
    {
        player = GameObject.Find("Player");
        lastEndPosition = levelPart_Start.Find("EndPosition").position;
        
        
    }
    private void Update()
    {
        if(Vector3.Distance(GameObject.Find("Player").transform.position, lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
        }
    }
    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }
    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
