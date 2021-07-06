using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] private int _minNumberOfObstacles = 1;
    [SerializeField] private int _maxNumberOfObstacles = 4;

    public Transform Obstacle;
    private Vector3 _spawnPosition;
    
    private int _numberOfObstacles;
    private int _minX = -4;
    private int _maxX = 4;
  


    private void Start()
    {
        _numberOfObstacles = Random.Range(_minNumberOfObstacles, _maxNumberOfObstacles);
        _spawnPosition.y = Obstacle.position.y;

        for (int i=0; i<_numberOfObstacles; i++)
        {
            _spawnPosition.x = Random.Range(_minX, _maxX);
            _spawnPosition.z = Random.Range(this.transform.position.z, this.transform.Find("End").position.z);
            Instantiate(Obstacle, _spawnPosition, Quaternion.identity);
        }

    }

}
