using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENE : MonoBehaviour
{
    public void LoadingScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        //_username = username.text;
        //Debug.Log(username.text);

    }
}
