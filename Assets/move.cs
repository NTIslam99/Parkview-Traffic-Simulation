using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    //int x = transform.position.x;
    //int y = transform.position.y;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {

        car.transform.position = Vector3.MoveTowards(car.transform.position, target1.transform.position, 5*Time.deltaTime);

    }
}
