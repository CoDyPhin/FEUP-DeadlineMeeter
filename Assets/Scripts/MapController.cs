using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{

    int mapSection;

    public EctsGenerator ectsGenerator;
    public ObstacleSpawner obstacleSpawner;

    bool sectionActive;

    public bool spawnActive;

    // Start is called before the first frame update
    void Start()
    {
        spawnActive = true;
        sectionActive = false;
        mapSection = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (!sectionActive && spawnActive){
            sectionActive = true;
            GenerateSection();
        }
    }

    void GenerateSection(){
        switch (mapSection){
            case 0:
            case 2:
                ectsGenerator.SpawnEcts(0);
                break;
            case 1:
                obstacleSpawner.respawnObstacle(0);
                break;
            case 3:
                // Coins on top, obstacle on bottom
                ectsGenerator.SpawnEcts(1);
                obstacleSpawner.respawnObstacle(1);
                break;
            case 4:
                ectsGenerator.SpawnEcts(2);
                obstacleSpawner.respawnObstacle(2);
                // Coins on bottom, obstacle on top
                break;
        }
    }

    public void NextSection(){
        sectionActive = false;
        if (mapSection == 4){
            mapSection = 0;
        } else {
            mapSection++;
        }
    }
}
