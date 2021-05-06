using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform pieceOfRoad;
    public Transform player;

    private Vector3 lastEnd;
    private float playerDistance = 150f;
    
    private void Start()
    {
        SpawnPieceOfRoad(pieceOfRoad.position);
        lastEnd = pieceOfRoad.Find("End").position;
    }

    private void Update()
    {
        if(Vector3.Distance(player.position,lastEnd)<playerDistance)
        {
            SpawnPieceOfRoad();
        }
    }

    private void SpawnPieceOfRoad()
    {
        Transform lastPieceOfRoad = SpawnPieceOfRoad(lastEnd);
        lastEnd = lastPieceOfRoad.Find("End").position;
    }
    
    private Transform SpawnPieceOfRoad(Vector3 spawnPosition)
    {
        Transform lastPieceOfRoad=Instantiate(pieceOfRoad, spawnPosition, Quaternion.identity);
        return lastPieceOfRoad;
    }


}
