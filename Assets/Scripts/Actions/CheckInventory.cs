using UnityEngine;
using System.Collections;

public class CheckInventory : Action {
    public GameController.Item itemID;
    public GameController.Flag flagID;
    //add noisemaker

	public override void Perform()
    {
        if (GameController.CheckInventory(itemID)){
            GameController.SetFlag(flagID);
            GameController.RemoveItem();
        }
        else
        {
            //play bad noise
        }

    }
}
