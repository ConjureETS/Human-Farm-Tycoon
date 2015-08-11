using UnityEngine;
using System.Collections;

public class OpenOtherScene : MonoBehaviour {

    public void OpenScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
