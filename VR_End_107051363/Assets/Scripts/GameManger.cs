using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public void RestartGame() 
    {
        SceneManager.LoadScene("籃球場");
    
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
  
}
