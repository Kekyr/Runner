using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform PieceOfRoad;
    public Transform Player;

    private Vector3 _lastEnd;
    private float _playerDistance = 150f;
    
    private void Start()
    {
        SpawnPieceOfRoad(PieceOfRoad.position);
        _lastEnd = PieceOfRoad.Find("End").position;
    }

    private void Update()
    {
        if(Vector3.Distance(Player.position,_lastEnd)<_playerDistance)
        {
            SpawnPieceOfRoad();
        }
    }

    private void SpawnPieceOfRoad()
    {
        Transform lastPieceOfRoad = SpawnPieceOfRoad(_lastEnd);
        _lastEnd = lastPieceOfRoad.Find("End").position;
    }
    
    private Transform SpawnPieceOfRoad(Vector3 spawnPosition)
    {
        Transform lastPieceOfRoad=Instantiate(PieceOfRoad, spawnPosition, Quaternion.identity);
        return lastPieceOfRoad;
    }


}
