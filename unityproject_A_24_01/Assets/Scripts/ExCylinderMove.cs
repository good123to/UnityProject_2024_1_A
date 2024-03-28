using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExCylinderMove : MonoBehaviour
{
    public float Speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(-1.0f, 0.0f, 0.0f) * Speed * Time.deltaTime;


        if(gameObject.transform.position.x < -12.0f)
        {
            gameObject.transform.position += new Vector3(24.0f, 0.0f, 0.0f);
        }
    }
}
