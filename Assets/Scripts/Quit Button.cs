using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public bool PlayerQuit = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public void PressedButton()
    {
        PlayerQuit = true;
    }

    public void ExitGame()
    {
        if (PlayerQuit == true)
        {
            Application.Quit();
        }
    }
}