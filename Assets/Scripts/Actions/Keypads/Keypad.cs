using UnityEngine;
using System.Collections;
using System.Collections.Generic;

abstract public class Keypad : Action {

	private List<char> input = new List<char> ();
	public List<char> answer = new List<char>();

	public void EnterKey(char key) {
		input.Add (key);

		if (input.Count >= answer.Count) {
			Perform ();

			input.Clear ();
		}
	}

	public override void Perform() {
		if (checkCode()) {
			//thing
		} else {
			// not thing
		}
	}

	private bool checkCode() {
		for (int i = 0; i < answer.Count; i++) {
			if (!answer [i].Equals (input [i])) {
				return false;
			}
		}

		return true;
	}

	abstract public void CodeCorrectPerform ();
	abstract public void CodeWrongPerform ();
}
