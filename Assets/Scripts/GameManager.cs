using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton 
    public static GameManager Instance;

    public bool isPausing = false;

    public List<GameObject> balls;

    public void PauseGame()
    {
        isPausing = true;
    }

    public void ResetGame()
    {
        // call load scene
    }
    public void OnEndGame()
    {
        //call end game 
        UIManager.instance.OnPauseGame();
    }
    public void StartGame()
    {
        isPausing = false;
    }

    private void Awake()
    {
        Instance = this;
        isPausing= true;
    }

    private void Start()
    {
        balls = new List<GameObject>();
    }

    public void RestartGame()
    {
        // Xoa bong'

        // Reset player's position
    }




}
