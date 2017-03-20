using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class startGameScene : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
    Application.LoadLevel(sceneName);
    }
}