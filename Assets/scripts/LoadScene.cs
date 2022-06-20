using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    
    public void LoadTargetScene(string sceneToLoad)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneToLoad);
        }

       
    }
    
}
