using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Restart : MonoBehaviour
{

    public void ChangeScene (string sceneName)
    {
        Scene scene;
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        //Application.LoadLevel(sceneName);
        GameObject.FindWithTag("Enemy").GetComponent<EnemyChase>().enabled = false;
    }

}