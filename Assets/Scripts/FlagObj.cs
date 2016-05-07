using UnityEngine;
using System.Collections;

public class FlagObj : MonoBehaviour {
    public GameController.Flag flagID;

	// Use this for initialization
	void Awake () {
        if (GameController.CheckFlag(flagID))
        {
            Destroy(this.gameObject);
        }
    }
	
}
