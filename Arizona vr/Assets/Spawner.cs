using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector3[] arr;
    public float lifetime;
    public int waveCount;
    public GameObject target;
    bool b = false;
    int count;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
        int spawned = targets.Length;
        Debug.Log($"spawned is {spawned}");
        if (spawned == 0 && count < waveCount)
            b = false;
        else
            b = true;
        if (b == false)
            StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        Destroy(Instantiate(target, arr[Random.Range(0, arr.Length)], Quaternion.identity), lifetime);
        count += 1;
        yield return new WaitForSeconds(3);
    }
}
