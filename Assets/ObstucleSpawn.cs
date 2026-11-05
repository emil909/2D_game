using UnityEngine;

public class ObstucleSpawn : MonoBehaviour
{
    public GameObject[] obstaclePrefab; // The obstacle prefab to spawn

    private int numberOfObstucles;
    public float initialSpawnInterval = 8f; // Time interval for the first spawn
    public float subsequentSpawnInterval = 3f; // Time interval for subsequent spawns
    public float spawnX = 10f; // Range for random X position

    private bool firstObstacleSpawned = false;

    public float speedIncrease = -0.1f; // Speed increase for each spawn

    private float timer;

    void Start()
    {
        timer = initialSpawnInterval;
        numberOfObstucles = obstaclePrefab.Length;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnObstacle();
            if (!firstObstacleSpawned)
            {
                timer = subsequentSpawnInterval;
                firstObstacleSpawned = true;
            }
            else
            {
                timer = subsequentSpawnInterval;
            }
        }
    }

    void SpawnObstacle()
    {
       
        Vector2 spawnPosition = new Vector2(spawnX, 0);

        GameObject newObstucle = Instantiate(obstaclePrefab[0], spawnPosition, Quaternion.identity);

        // Apply random scaling to the obstacle
        float randomScaleX = Random.Range(1f, 2f);
        float randomScaleY = Random.Range(1f, 2f);
        newObstucle.transform.localScale = new Vector2(newObstucle.transform.localScale.x * randomScaleX, newObstucle.transform.localScale.y * randomScaleY);

        // Adjust the Y position based on the random Y scale
        newObstucle.transform.position = new Vector2(newObstucle.transform.position.x, newObstucle.transform.position.y + randomScaleY / 2);

        newObstucle.GetComponent<ObstucleSpeedScript>().speed += speedIncrease;

        Destroy(newObstucle, 10f);
    }
}
