using UnityEngine;

/// <summary>
/// Start or quit the game
/// </summary>
public class MenuScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 500;
		const int buttonHeight = 300;
		GUIStyle mystyle = new GUIStyle (GUI.skin.button);
		mystyle.fontSize = 200;

		if (
			GUI.Button(
				// Center in X, 1/3 of the height in Y
				new Rect(Screen.width / 2 - (buttonWidth / 2),
					(1 * Screen.height / 3) - (buttonHeight / 2),
					buttonWidth,
					buttonHeight),
				"Start",mystyle
			)
		)
		{
			// Reload the level
			Application.LoadLevel("group");
		}

		if (
			GUI.Button(
				// Center in X, 2/3 of the height in Y
				new Rect(Screen.width / 2 - (buttonWidth / 2),
					(2 * Screen.height / 3) - (buttonHeight / 2),
					buttonWidth,
					buttonHeight),
				"Exit",mystyle)
		)
		{
			// Reload the level
			Application.Quit();
		}
	}
}