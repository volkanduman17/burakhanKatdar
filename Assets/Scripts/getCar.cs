using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCar : MonoBehaviour
{

    public GameObject carPlayer;
    public GameObject tPose;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="car")
        {
            carPlayer.SetActive(true);
            tPose.SetActive(false);
            gameObject.GetComponent<Stash>().maxCollectableCount = 10;
            gameObject.GetComponent<Movement>().Speed = 30;

        }
    }
}
