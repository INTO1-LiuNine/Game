using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int SceneBuildIndex;
    // Start is called before the first frame update
    private void OnTrigrerEnter2D(Collider2D other)
    {
        print("Trigger Entered");
        if(other.tag == "Player")
        {
            print("Switching Scene to " + SceneBuildIndex);
            SceneManager.LoadScene(SceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
