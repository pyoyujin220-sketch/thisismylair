using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    public GameObject ToggleCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void ActiveUI()
    {
        if (ToggleCanvas != null)
        {

            ToggleCanvas.SetActive(true);
        }
    }

    public void DeActiveUI()
    {
        if (ToggleCanvas != null)
        {
            ToggleCanvas.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
