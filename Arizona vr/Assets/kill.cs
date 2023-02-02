using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    public Material successMat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.GetComponent<Collider>().tag == "Target") {
            col.GetComponent<MeshRenderer>().material = successMat;
            Destroy(col.gameObject, .5f);
        }
    }
}
