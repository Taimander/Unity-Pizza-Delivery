using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPointer : MonoBehaviour
{

    ObjectivesManager objectivesManager;

    void Start()
    {
        objectivesManager = GameObject.Find("Objectives").GetComponent<ObjectivesManager>();
    }

    void Update()
    {
        if(objectivesManager.GetCurrent() != null) {
            transform.LookAt(objectivesManager.GetCurrent().transform.position, Vector3.forward);
            transform.Rotate(90,0,0);
        }
    }
}
