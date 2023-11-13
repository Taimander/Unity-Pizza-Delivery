using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{

    public GameObject prefab;
    
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            GameObject.Find("ScoreManager").GetComponent<Score>().AddScore(1);
            Object.Destroy(prefab);
        }
    }

}
