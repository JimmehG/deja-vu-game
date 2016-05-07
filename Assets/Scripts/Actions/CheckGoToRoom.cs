using UnityEngine;
using System.Collections;

public class CheckGoToRoom : GoToRoom {
    public int DoorID;

    public override void Perform()
    {
        if (GameController.open(DoorID))
            base.Perform();
        else
        {
            //locked noise
        }
    }
}
