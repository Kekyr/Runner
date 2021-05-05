using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{

    public GameObject[] obstacles;
    private Vector3 position;
    
    private void Start()
    {
        position.y = 0.57f;
        foreach (var obs in obstacles)
        {
            position.x = Random.Range(-4,4);
            position.z = Random.Range(-25,6);
            Instantiate(obs, position, Quaternion.identity);
        }
        
    }

}
