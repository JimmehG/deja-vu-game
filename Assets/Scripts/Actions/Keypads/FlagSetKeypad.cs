using UnityEngine;
using System.Collections;

public class FlagSetKeypad : Keypad {

	public GameController.Flag flag;

	public override void CodeCorrectPerform() {
		GameController.SetFlag (flag);
	}

	public override void CodeWrongPerform() {

	}
}
