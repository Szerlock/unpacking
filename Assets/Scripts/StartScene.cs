using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    //[SerializeField]
    //private GameObject shelve;
    [SerializeField]
    private GameObject floor;
    
    void Start()
    {
        //Instantiate(shelve, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(floor, new Vector3(0.5f, -5, 0), Quaternion.identity);
    }  

    void Update()
    {
        
    }
}
