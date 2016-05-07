using UnityEngine;
using System.Collections;

public class StartThenGoToRoom : GoToRoom {

    public override void Perform()
    {
        StopAnimation stopAnimation = transform.parent.GetComponent<StopAnimation>();
        if (stopAnimation.clickable)
        {
            if (stopAnimation.final)
            {
                base.Perform();
            }
            else
            {
                stopAnimation.Start();
            }
        }
    }
}
