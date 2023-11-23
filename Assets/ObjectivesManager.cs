using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivesManager : MonoBehaviour
{

    private GameObject current;
    public GameObject homePos;
    public GameObject objectivePrefab;
    private bool isHome = true;

    void Update()
    {
        if(current == null) {
            if(!isHome) {
                isHome = true;
                current = Instantiate(objectivePrefab, homePos.transform.position, Quaternion.identity);
            } else {
                isHome = false;
                List<GameObject> children = new List<GameObject>();
                foreach (Transform child in transform) {
                    children.Add(child.gameObject);
                }
                int index = Random.Range(0, children.Count);
                current = Instantiate(objectivePrefab, children[index].transform.position, Quaternion.identity);
            } 
        }
    }

    public void ForceNext() {
        if(current != null) {
            Destroy(current);
            current = null;
        }
    }

    public bool IsHomeNow() {
        return isHome;
    }

}
