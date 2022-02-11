using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPOB_3m : MonoBehaviour
{
    GameObject content; //Cubeオブジェクトを入れる変数
 
    void Start()
    {

    }
 
    void Update()
    {
        Vector3 conPos = GameObject.Find("Content").transform.position;
        Vector3 objPos = this.transform.position;
        //Debug.Log(conPos.x);
        this.transform.position = new Vector3(0.65f - Mathf.Abs(-26f - conPos.x) / 53.4f *
        0.65f, objPos.y, objPos.z);
    }
}
