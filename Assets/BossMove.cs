using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float speed = 3.0f;
    public float deadLine = -20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
       
        if (transform.position.z <= 0.2)
        {
            pos.z = 0.2f;
            transform.position = pos;
        }
        else
        {
            pos.z -= speed * Time.deltaTime;
            transform.position = pos;
        }
    }
}
