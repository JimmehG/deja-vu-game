using UnityEngine;
using System.Collections;

public class StartThenGoToRoom : GoToRoom {
    private bool pressed = false;

    public override void Perform()
    {
        StopAnimation stopAnimation = transform.parent.GetComponent<StopAnimation>();
        if (pressed && stopAnimation.clickable)
        {
            base.Perform();
        }
        else
        {
            pressed = true;
            stopAnimation.Start();
        }
    }
}
