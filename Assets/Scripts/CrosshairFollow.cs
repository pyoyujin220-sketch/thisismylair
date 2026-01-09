using UnityEngine;

public class CrosshairFollow : MonoBehaviour
{
    public RectTransform crosshair;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 원래 마우스 커서 숨기기
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        // 크로스 헤어가 마우스의 xy축 값을 받아서 움직이게 하기
        crosshair.position = Input.mousePosition;
    }

    // 공격 시스템에서 사용할 좌표
    public Vector2 GetCrosshairScreenPosition()
    {
        return crosshair.position;
    }
}
