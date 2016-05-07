using UnityEngine;
using System.Collections;
using System;

public class PickupItem : Action {
    public GameController.Item itemID;
    public GameController.Flag flagID;
    public override void Perform()
    {
        GameController.PickupItem(itemID);
        GameController.SetFlag(flagID);
        Destroy(this.gameObject);
    }

    void Start()
    {
        if (GameController.CheckFlag(flagID))
        {
            Destroy(this.gameObject);
        }
    }
}
