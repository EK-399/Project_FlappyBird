using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    [SerializeField] float pipeSpawnDelay;
    float countdown;

    FlappyBirdController flappyBirdController;

    void Start()
    {
        countdown = pipeSpawnDelay;
        flappyBirdController = FindFirstObjectByType<FlappyBirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flappyBirdController.gameStarted == false)
        {
            return;
        }

        countdown -= Time.deltaTime;
        if(countdown <= 0)
        {
            Instantiate(pipePrefab. transform);
            countdown = pipeSpawnDelay;
        }
    }
}
