using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
public Button[] levelButtons;

int currentScene;




void Start()
{

int levelReached = PlayerPrefs.GetInt("levelReached");
if (levelReached == 0)
{
levelReached = 1;    
}

for (int i = 0; i < levelButtons.Length; i++)
{
if (i < levelReached)
{
levelButtons[i].interactable = true;
}
}
}


public void LoadScene(int index)
{
SceneManager.LoadScene(index);
}
public void LoadNextLevel()
{
SceneManager.LoadScene(currentScene + 1);
}


}