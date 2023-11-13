using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimapVisibilityManager : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
            GetComponent<RawImage>().enabled = !GetComponent<RawImage>().enabled;
    }
}
