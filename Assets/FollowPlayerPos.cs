using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerPos : MonoBehaviour
{
    public GameObject player;
    public float yPos;

    void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x, yPos, player.transform.position.z);
    }
}
