using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void VolverAlMenu()
    {
        SceneManager.LoadScene("00_Menu");
    }
}