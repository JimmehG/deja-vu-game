using UnityEngine;
using System.Collections;
using System;

public class Activate : Action {
    public GameController.Flag flagID;

    public override void Perform()
    {
        GameController.SetFlag(flagID);
    }

}
