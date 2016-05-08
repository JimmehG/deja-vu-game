using UnityEngine;
using System.Collections;

public class TriggerButton : Action
{

	public GameController.Flag flagID;

	public override void Perform()
	{
		if (!GameController.CheckFlag(flagID)) {
			GameController.SetFlag(flagID);
			//play noise
		}
		else
		{
			//play bad noise
		}
	}
}

