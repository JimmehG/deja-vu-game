using UnityEngine;
using System.Collections;

public class UpdateObj : MonoBehaviour {
    public GameController.Flag flagID;

	public void activateCollider()
    {
        if (GameController.CheckFlag(flagID))
        {
            GetComponentInChildren<BoxCollider2D>().enabled = true;
        }
    }
}
