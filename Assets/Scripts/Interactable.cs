using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {
    public Action action;

	void OnMouseDown()
    {
        action.Perform();
    }

    //glow when button held (low priority polish) (could be a different method which finds all interactables by tag or something)
}
