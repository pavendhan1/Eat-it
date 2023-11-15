using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Span : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spanrangeX = 20;
    private float spanrangeY = 20;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spanAnimals", 2, 1.5f) ; 
    }

    // Update is called once per frame 
    void Update()
    {
        
    }
    void spanAnimals()
    {
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-20, 20), 0, spanrangeY);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }













}
