using UnityEngine;
using System.Collections;

public class RemoveToRoom : GoToRoom {
    public GameController.Flag flagID;

    public override void Perform()
    {
        base.Perform();
    }

    void Start()
    {
        if (GameController.CheckFlag(flagID))
        {
            Destroy(this.gameObject);
        }
    }
}
