using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour {   
    public GameObject meteorPrefab;
    public float spawnRatePerMin = 30;
    public float spawnRateIncrement = 1;

    private float spawnNext = 0;
    // Update is called once per frame
    void Update() {
        if(Time.time > spawnNext){
            spawnNext = Time.time + (60/spawnRatePerMin);
            spawnRateIncrement += spawnRateIncrement;

            float randX = Random.Range(-9, 9);

            var spawnPosition = new Vector3(randX, transform.position.y, -1);

            Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
