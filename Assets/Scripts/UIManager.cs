using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;

    public Button startBtn;
    public GameObject uiParent;
    public void OnClickBtnStart()
    {
        if (GameManager.Instance != null)
        {
            OnStartGame();
            GameManager.Instance.StartGame();
        }

       
    }

    void Awake()
    {
        instance = this;
    }

    public void OnPauseGame()
    {
        ToggleUI(true);
    }
        

    void ToggleUI(bool enableUI)
    {
        uiParent.SetActive(enableUI);
    }
    public void OnStartGame()
    {
        ToggleUI(false);
    }


    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
