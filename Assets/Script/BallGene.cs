using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGene : MonoBehaviour
{
    public GameObject ballPrefub;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject ball = Instantiate(ballPrefub) as GameObject;

            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 world = r.direction;
            ball.GetComponent<Ball>().Throw(world.normalized * 1500);

            //ball.GetComponent<Ball>().Throw(new Vector3(0, 300, 1500));
        }
        
    }
}
