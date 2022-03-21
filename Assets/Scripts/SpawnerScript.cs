using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] GameObject cubeToGo;
    [SerializeField] InputField timeInput;
    [SerializeField] InputField speedInput;
    [SerializeField] InputField distanceInput;
    public float timeToSpawn = 1;
    public float cubeSpeed = 1;
    public float distanceToGo = 5;
    private float currentTime = 0;

    private void Start()
    {

    }

    private void Update()
    {
        GetValues();
        currentTime += Time.deltaTime;
        if (currentTime > timeToSpawn)
        {
            currentTime = 0;
            Instantiate(cubeToGo, transform.position, Quaternion.identity);
        }
    }

    private void GetValues()
    {
        if (float.TryParse(timeInput.text, out float time))
        {
            timeToSpawn = time;
        }
        if (float.TryParse(speedInput.text, out float speed))
        {
            cubeSpeed = speed;
        }
        if (float.TryParse(distanceInput.text, out float distance))
        {
            distanceToGo = distance;
        }
    }
}
