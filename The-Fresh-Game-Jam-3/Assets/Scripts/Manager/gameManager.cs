using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
public void WinLevel()
{
PlayerPrefs.SetInt("levelReached", PlayerPrefs.GetInt("levelReached") + 1);
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
}
