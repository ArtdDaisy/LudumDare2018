﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodBehaviour : MonoBehaviour {

    int soulCount;
    int soulNeeded;

    private void Start()
    {
        soulNeeded = GameManager.instance.worldVariables.startSoulAmount;
    }

    public void Clicked()
    {
        print("Go to minigame");
        AddSoul(2);
    }

    public void AddSoul(int amount)
    {
        soulCount += amount;

        if(soulCount >= soulNeeded)
        {
            soulCount = soulCount - soulNeeded;
            soulNeeded += GameManager.instance.worldVariables.soulProgression;
            GameManager.GrowCrop();
        }
    }
}
