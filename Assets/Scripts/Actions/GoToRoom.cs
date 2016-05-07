using UnityEngine;
using System.Collections;

public class GoToRoom : Action {
    public GameObject room;

    public override void Perform()
    {
        goRoom();
    }

    public void goRoom()
    {
        Instantiate(room);
        Destroy(transform.parent.gameObject);
    }

}
