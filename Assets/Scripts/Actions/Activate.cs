using UnityEngine;
using System.Collections;
using System;

public class Activate : Action {
    public GameController.Flag flagID;
    public override void Perform()
    {
        StopAnimation stopAnimation = GetComponent<StopAnimation>();
        if (stopAnimation.clickable)
        {
            stopAnimation.Start();
            GameController.SetFlag(flagID);
        }
    }

}
