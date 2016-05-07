using UnityEngine;
using System.Collections;

public class PickupToRoom : PickupItem {
    public GameObject room;

    public override void Perform()
    {
        base.Perform();
        goRoom();
    }

    public void goRoom()
    {
        Instantiate(room);
        Destroy(transform.parent.gameObject);
    }
}
