using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivesManager : MonoBehaviour
{

    private GameObject current;
    public GameObject objectivePrefab;

    void Update()
    {
        if(current == null) {
            List<GameObject> children = new List<GameObject>();
            foreach (Transform child in transform) {
                children.Add(child.gameObject);
            }
            int index = Random.Range(0, children.Count);
            current = Instantiate(objectivePrefab, children[index].transform.position, Quaternion.identity);
        } 
    }
}
