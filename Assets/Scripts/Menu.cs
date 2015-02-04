using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
	public string current_menu;

	void Start()
	{
		current_menu = "Main";
	}

	void OnGUI()
	{
		if(current_menu == "Main")
		{
			mainMenu();
		}

		if(current_menu == "New Game")
		{
			newGameMenu();
		}

		if(current_menu == "Load Game")
		{
			loadGameMenu();
		}

		if(current_menu == "Options")
		{
			optionsMenu();
		}

		if(current_menu == "Quit")
		{
			quitMenu();
		}
	}

	public void goToMenu(string next_menu)
	{
		current_menu = next_menu;
	}

	private void mainMenu()
	{
		if(GUI.Button (new Rect(Screen.width / 2.0f - 100, Screen.height / 3.0f + 50, 200, 50), "New Game"))
		{
			goToMenu("New Game");
		}

		if(GUI.Button (new Rect(Screen.width / 2.0f - 100, Screen.height / 3.0f + 125, 200, 50), "Load Game"))
		{
			goToMenu("Load Game");
		}

		if(GUI.Button (new Rect(Screen.width / 2.0f - 100, Screen.height / 3.0f + 200, 200, 50), "Options"))
		{
			goToMenu("Options");
		}

		if(GUI.Button (new Rect(Screen.width / 2.0f - 100, Screen.height / 3.0f + 275, 200, 50), "Quit"))
		{
			goToMenu("Quit");
		}
	}

	private void newGameMenu()
	{
		if(GUI.Button (new Rect(Screen.width / 2.0f - 100, Screen.height / 3.0f + 50, 200, 50), "Start Game"))
		{
			Application.LoadLevel("Level 1");
		}

		if(GUI.Button (new Rect(Screen.width / 2.0f - 100, Screen.height / 3.0f + 275, 200, 50), "Back"))
		{
			goToMenu("Main");
		}
	}

	private void loadGameMenu()
	{
		if(GUI.Button (new Rect(Screen.width / 2.0f - 100, Screen.height / 3.0f + 275, 200, 50), "Back"))
		{
			goToMenu("Main");
		}
	}

	private void optionsMenu()
	{
		if(GUI.Button (new Rect(Screen.width / 2.0f - 100, Screen.height / 3.0f + 275, 200, 50), "Back"))
		{
			goToMenu("Main");
		}
	}

	private void quitMenu()
	{
		Application.Quit();	
	}
}
