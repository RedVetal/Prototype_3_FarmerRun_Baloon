using UnityEngine;

public class SpawnManager : MonoBehaviour // add this script to object SpawnManager
{
    public GameObject obstaclePrefab;  // drag and drop obstacle prefab from Assets folder to this box
    private Vector3 spawnPosition = new Vector3(25, 0, 0);

    private float startDelay = 2f;
    private float repeatRate = 2f;
    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }
}
