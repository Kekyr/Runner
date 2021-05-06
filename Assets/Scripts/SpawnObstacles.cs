using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] private int minNumberOfObstacles = 1;
    [SerializeField] private int maxNumberOfObstacles = 4;

    public Transform obstacle;
    private Vector3 spawnPosition;
    
    private int numberOfObstacles;
    private int minX = -4;
    private int maxX = 4;
  


    private void Start()
    {
        numberOfObstacles = Random.Range(minNumberOfObstacles, maxNumberOfObstacles);
        spawnPosition.y = obstacle.position.y;

        for (int i=0; i<numberOfObstacles; i++)
        {
            spawnPosition.x = Random.Range(minX, maxX);
            spawnPosition.z = Random.Range(this.transform.position.z, this.transform.Find("End").position.z);
            Instantiate(obstacle, spawnPosition, Quaternion.identity);
        }

    }

}
