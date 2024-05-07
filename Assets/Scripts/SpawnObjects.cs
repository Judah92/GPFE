using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject Target;
    public int numberOfTargets = 4;

    void Start()
    {
        SpawnTargets();
    }

    void SpawnTargets()
    {
        for (int i = 0; i < numberOfTargets; i++)
        {
            float spawnX = Random.Range(-4.0f, 4.0f);
            float spawnY = Random.Range(-4.0f, 4.0f);
            Vector3 spawnPosition = new Vector3(spawnX, 0.5f, spawnY);
            Instantiate(Target, spawnPosition, Quaternion.identity);
        }
    }
}