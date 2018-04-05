using UnityEngine.SceneManagement;
using UnityEngine;

public class UIController : MonoBehaviour {

    private bool activeUI = false;
    public bool _activeUI
    {
        get { return activeUI; }
        set
        {
            activeUI = value;
            gameObject.SetActive(activeUI);
        }
    }
    
    public void ContinueButton()
    {
        _activeUI = false;
    }

    public void NewGameButton()
    {
        StaticData.saveExist = false;
        StaticData.isWin = false;
        SceneManager.LoadScene(1);
    }

    public void ExitToMenuButton()
    {
        GameObject.Find("Player").GetComponent<Player>().SaveData();
        StaticData.saveExist = !StaticData.isWin;
        SceneManager.LoadScene(0);
    }
}
