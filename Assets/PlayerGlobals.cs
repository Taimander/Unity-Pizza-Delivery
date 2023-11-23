using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGlobals
{
    public static PlayerGlobals Instance { get; private set; }

    public static PlayerGlobals GetInstance() {
        if(Instance == null)
            Instance = new PlayerGlobals();
        return Instance;
    }

    public int score = 0;
}
