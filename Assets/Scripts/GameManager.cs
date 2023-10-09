using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton 
    public static GameManager Instance;

    public bool isPausing = false;

    public List<GameObject> balls;

    public Transform player;

    public void PauseGame()
    {
        isPausing = true;
    }

    public void ResetGame()
    {
        // Load lại cảnh hiện tại
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
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
        //// Xóa tất cả các bóng
        //foreach (GameObject ball in balls)
        //{
        //    Destroy(ball);
        //}

        //// Đặt lại vị trí của người chơi (thay thế Vector3 bằng vị trí ban đầu của người chơi)
        //player.position = new Vector3(0f, -3.36f, 0f);  // Thay thế Vector3 bằng vị trí ban đầu của người chơi
    }

}
