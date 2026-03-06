using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    public GameObject SettingCanvas;
    public GameObject gameoverCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(gameoverCanvas!=null)
        {
            gameoverCanvas.SetActive(false);
        }
    }

    public void ActiveUI()
    {
        if (SettingCanvas != null)
        {

            SettingCanvas.SetActive(true);
        }
    }

    public void DeActiveUI()
    {
        if (SettingCanvas != null)
        {
            SettingCanvas.SetActive(false);
        }
    }

    public void GameOver()
    {
        if(gameoverCanvas!=null)
        {
            Time.timeScale = 0;
            gameoverCanvas.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
