using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private void Start()
    {
        transform.Find("ContinueButton").gameObject.SetActive(StaticData.saveExist);
    }
    public void OnExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void LoadGameButton(bool continueGame)
    {
        StaticData.pressContinue = continueGame;
        SceneManager.LoadScene(1);
    }
}
