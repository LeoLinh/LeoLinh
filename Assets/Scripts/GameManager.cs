using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton 
    public static GameManager Instance;

    public List<GameObject> balls;

    private void Awake()
    {
        Instance = this;
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
