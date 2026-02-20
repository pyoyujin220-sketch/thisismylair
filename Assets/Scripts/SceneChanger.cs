using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public string NextStageSceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void GameStart()
    {
        if (NextStageSceneName!=null)
        SceneManager.LoadScene(NextStageSceneName);
    }

    public void GameQuit()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
