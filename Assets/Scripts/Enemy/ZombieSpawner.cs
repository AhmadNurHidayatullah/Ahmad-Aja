using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public float spawnInterval = 1f;

    // Posisi Y tiap lane (sesuai grid)
    public float[] laneYPositions = { 1f, 0f, -1f };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnZombie), 1f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnZombie()
    {
        int laneIndex = Random.Range(0, laneYPositions.Length);
        float yPos = laneYPositions[laneIndex];

        Vector2 spawnPos = new Vector2(transform.position.x, yPos);
        Instantiate(zombiePrefab, spawnPos, Quaternion.identity);
    }
}
