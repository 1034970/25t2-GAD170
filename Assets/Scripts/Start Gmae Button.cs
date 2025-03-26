using UnityEngine;

public class StartGmaeButton : MonoBehaviour
{
    public bool Paused = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void PressedButton()
    {
        Paused = false;
    }
}
