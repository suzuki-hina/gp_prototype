using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActiveUi : MonoBehaviour
{
    public GameObject On1;
    public GameObject On2;
    public GameObject On3;
    public GameObject Off1;
    public GameObject Off2;
    public GameObject Off3;
    public GameObject Off4;
    public GameObject Off5;


    public void OnClickStartButton()
    {
        On1.SetActive (true);
        On2.SetActive (true);
        On3.SetActive (true);
        Off1.SetActive (false);
        Off2.SetActive (false);
        Off3.SetActive (false);
        Off4.SetActive (false);
        Off5.SetActive (false);
    }
}
