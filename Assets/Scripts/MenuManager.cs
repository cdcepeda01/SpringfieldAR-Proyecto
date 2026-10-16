using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void AbrirImageTarget()
    {
        SceneManager.LoadScene("01_ImageTargets");
    }

    public void AbrirGroundPlane()
    {
        SceneManager.LoadScene("02_GroundPlane");
    }

    public void AbrirMidAir()
    {
        SceneManager.LoadScene("03_MidAir");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
