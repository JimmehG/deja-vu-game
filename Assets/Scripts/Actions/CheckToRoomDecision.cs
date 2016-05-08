using UnityEngine;
using System.Collections;

public class CheckToRoomDecision : GoToRoom {
    public GameController.Flag lockID;
    public GameController.Flag decisionID;
    public GameObject dRoom;

    public override void Perform()
    {
        if (GameController.CheckFlag(lockID))
        {
            if (GameController.CheckFlag(decisionID))
            {
                room = dRoom;
                base.Perform();
            }
            else
            {
                base.Perform();
            }

        }
    }
}
