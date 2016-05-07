using UnityEngine;
using System.Collections;

public class StopAnimation : MonoBehaviour {

    internal bool clickable = false;
    internal bool final = false;

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
    
    public void Final()
    {
        Stop();
        final = true;
    }
}
