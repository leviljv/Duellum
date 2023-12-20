using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTutorial : MonoBehaviour {
    private void Update() {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(0);
    }

    public void Btn_Reset() {
        SceneManager.LoadScene(0);
    }

}
