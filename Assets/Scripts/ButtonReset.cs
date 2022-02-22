using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonReset : MonoBehaviour
{
  
    
    public void onButtonClick()
    {
        reloadScene();
    }
    public void reloadScene()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
