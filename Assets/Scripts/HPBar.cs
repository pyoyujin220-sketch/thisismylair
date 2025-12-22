using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Health targetHealth;
    public Image fillImage;

    Camera mainCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // 체력 비율 반영
        fillImage.fillAmount = targetHealth.GetHPRatio();

        // 항상 카메라를 바라보게
        transform.forward = mainCamera.transform.forward;
    }
}
