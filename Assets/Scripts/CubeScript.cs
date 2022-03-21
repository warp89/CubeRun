using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private SpawnerScript properties;
    private Rigidbody cubeRigidbody;
    private Vector3 startPosition;
    private float finishDistance;

    private void Start()
    {
        properties = FindObjectOfType<SpawnerScript>();
        cubeRigidbody = GetComponent<Rigidbody>();
        startPosition = properties.transform.position;
        finishDistance = properties.distanceToGo;
    }


    private void Update()
    {
        cubeRigidbody.velocity = Vector3.forward * properties.cubeSpeed;
        if (Vector3.Distance(transform.position, startPosition) > finishDistance)
        {
            Destroy(gameObject);
        }
    }
}
