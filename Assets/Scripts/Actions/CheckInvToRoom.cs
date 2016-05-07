using UnityEngine;
using System.Collections;

public class CheckInvToRoom : GoToRoom {
    public GameController.Item itemID;

    public override void Perform()
    {
        if (GameController.CheckInventory(itemID))
        {
            GameController.RemoveItem();
            base.Perform();
        }
        else
        {
            //play bad noise
        }
    }
}
