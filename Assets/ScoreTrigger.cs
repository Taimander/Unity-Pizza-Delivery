using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            GameObject.Find("ScoreManager").GetComponent<Score>().AddScore(1);
            Object.Destroy(this.gameObject);
        }
    }

}
