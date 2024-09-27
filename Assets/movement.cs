using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    public float speed = 10.0f;
    public GameObject Maze;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        //translation *= Time.deltaTime;
        //rotation *= Time.deltaTime;


        Maze.transform.rotation = Quaternion.Euler(translation, rotation, 0);
                

    }
}
