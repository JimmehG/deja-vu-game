using UnityEngine;
using System.Collections;

public class StopAnimation : MonoBehaviour {

    internal bool clickable = false;

	public void Stop()
    {
        GetComponent<Animator>().enabled = false;
        clickable = true;
    }

    public void Start()
    {
        GetComponent<Animator>().enabled = true;
        clickable = false;
    }
}
