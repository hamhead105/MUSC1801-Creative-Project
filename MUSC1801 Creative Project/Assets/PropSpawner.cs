using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnable;
    [SerializeField] private float spawnChance; // out of 100, where higher is more common
    private float spawnFrequency = 0.25f;
    [SerializeField] private int[] spawnableProps;

    private Vector3 spawnRange;

    [SerializeField] private Vector3 propMovement;

    [SerializeField] private float minDelay;
    [SerializeField] private float floatDelayCounter = 0;

    [SerializeField] private Vector3 propScale;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CheckSpawn", spawnFrequency, spawnFrequency);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckSpawn()
    {
        floatDelayCounter -= spawnFrequency;
        if (Random.Range(1, 100) <= spawnChance && floatDelayCounter <= 0)
        {
            floatDelayCounter = minDelay;
            GameObject prop = Instantiate(spawnable, this.transform.position, transform.rotation);
            prop.transform.localScale = new Vector3(propScale.x, propScale.y, propScale.z);
            prop.GetComponent<DrawnProp>().SetStats(propMovement, spawnableProps[Random.Range(0,spawnableProps.Length)]);
        }
    }
}
