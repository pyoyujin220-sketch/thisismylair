using Unity.VisualScripting;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    public GameObject SettingCanvas;
    public GameObject gameoverCanvas;
    public GameObject crosshairCanvas;
    public GameObject playerSkillCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(gameoverCanvas!=null)
        {
            gameoverCanvas.SetActive(false);
        }
        if (playerSkillCanvas == null)
        {
            playerSkillCanvas = GetComponent<GameObject>();
        }
    }

    // 시간을 멈추는 함수
    void PauseGame()
    {
        Time.timeScale = 0.0f;
    }

    // 게임 다시 재생하는 함수
    void ContinueGame()
    {
        Time.timeScale = 1.0f;
    }

    public void Unenableplayerskillcanvas()
    {
        playerSkillCanvas.SetActive(false);
    }

    public void UsePlayerSkill()
    {
        playerSkillCanvas.SetActive(true);
        Invoke(nameof(Unenableplayerskillcanvas), 1.0f);
    }

    public void ActiveUI()
    {
        if (SettingCanvas != null)
        {
            PauseGame();
            SettingCanvas.SetActive(true);
            // 크로스 헤어 안 보이고 마우스 커서 보이게
            crosshairCanvas.SetActive(false);
            Cursor.visible = true;
        }
    }

    public void DeActiveUI()
    {
        if (SettingCanvas != null)
        {
            SettingCanvas.SetActive(false);
            // 마우스 커서 안보이게 하고, 크로스헤어 다시 보이게
            crosshairCanvas.SetActive(true);
            Cursor.visible = false;
            ContinueGame();
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
