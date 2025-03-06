using UnityEngine;

public class ObstucleSpawn : MonoBehaviour
{
    public GameObject[] obstaclePrefab; // The obstacle prefab to spawn

    private int numberOfObstucles;
    public float spawnIntervalSeconds = 0.5f; // Time interval between spawns
    public float spawnX = 10f; // Range for random X position

    private int firstObstucles = 0;

    public float speedIncrease = -0.1f; // Speed increase for each spawn

    private float timer;

    void Start()
    {
        timer = spawnIntervalSeconds;
        numberOfObstucles = obstaclePrefab.Length;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnObstacle();
            timer = spawnIntervalSeconds;
        }
    }

    void SpawnObstacle()
    {
        int randomObstucleIndex = Random.Range(numberOfObstucles - numberOfObstucles - 1, numberOfObstucles + 1);
        //float randomY = Random.Range(-spawnRangeY, spawnRangeY);
        Vector2 spawnPosition = new Vector2(6, 0);
        


        GameObject newObstucle = Instantiate(obstaclePrefab[randomObstucleIndex], spawnPosition, Quaternion.identity);
      
      
            speedIncrease -= 0.5f;
            newObstucle.GetComponent<ObstucleSpeedScript>().speed += speedIncrease;
            //spawnIntervalSeconds += 0.2f;
            
        
        
        
    }
}
