using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDieTransition : Transition
{
    
    void Update()
    {
        if (Target._currentHealth <= 0)
            NeedTransit = true;
    }
}
