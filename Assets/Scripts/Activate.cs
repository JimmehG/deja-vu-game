using UnityEngine;
using System.Collections;
using System;

public class Activate : MonoBehaviour {
    public GameController.Flag flagID;

    public void Trigger()
    {
        GameController.SetFlag(flagID);
    }

}
