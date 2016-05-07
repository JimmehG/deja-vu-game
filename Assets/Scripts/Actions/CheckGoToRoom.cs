using UnityEngine;
using System.Collections;

public class CheckGoToRoom : GoToRoom {
    public GameController.Flag flagID;
    //public noisemaker

    public override void Perform()
    {
        if (GameController.CheckFlag(flagID))
            base.Perform();
        else
        {
            //locked noise
        }
    }
}
