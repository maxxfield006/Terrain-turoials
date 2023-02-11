using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject car;
    public Vector3 offset = new Vector3(0, 3, -5);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position + offset;
    }
}
