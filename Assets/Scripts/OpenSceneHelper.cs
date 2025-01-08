using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSceneHelper : MonoBehaviour
{
    public string sceneToOpen;

    // Start is called before the first frame update
    public void OpenScene()
    {
        SceneManager.LoadScene(sceneToOpen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
