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
            Destroy(this.gameObject);
        }
        else
        {
            //play bad noise
        }

    }

    void Start()
    {
        if (GameController.CheckFlag(flagID))
        {
            Destroy(this.gameObject);
        }
    }
}
