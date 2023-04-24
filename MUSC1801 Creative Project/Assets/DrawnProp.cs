using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawnProp : MonoBehaviour
{
    [SerializeField] private Vector3 movement;
    [SerializeField] private int propNumber;
    [SerializeField] private float destroyAfter = 45f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyAfter);
    }

    public void SetStats(Vector3 movement, int propNumber)
    {
        GetComponent<Animator>().SetInteger("Prop Number", propNumber);
        this.movement = movement;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movement * Time.deltaTime); 
    }
}
