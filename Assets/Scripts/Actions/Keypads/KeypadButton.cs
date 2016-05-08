using UnityEngine;
using System.Collections;

public class KeypadButton : Action
{
	public char key;
	private Keypad keypad;

	void Start()
	{
		keypad = GetComponentInParent<Keypad>();
	}

	public override void Perform()
	{
		keypad.EnterKey (key);
	}
}
