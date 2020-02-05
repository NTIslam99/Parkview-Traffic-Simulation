using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class move : MonoBehaviour
{
    //int x = transform.position.x;
    //int y = transform.position.y;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public int point = 1;
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        switch (point) {
            case 1: car.transform.position = Vector3.MoveTowards(car.transform.position, target1.transform.position, 3 * Time.deltaTime);
                if (car.transform.position == target1.transform.position)
                {
                    Thread.Sleep(3000);
                    point = 2;
                }
                break;
            case 2:
                car.transform.position = Vector3.MoveTowards(car.transform.position, target2.transform.position, 3 * Time.deltaTime);
                if (car.transform.position == target2.transform.position)
                {
                    Thread.Sleep(3000);
                    point = 3;
                }
                break;
            case 3:
                car.transform.position = Vector3.MoveTowards(car.transform.position, target3.transform.position, 3 * Time.deltaTime);
                break;
            default:
                break;
        }
    }
}
