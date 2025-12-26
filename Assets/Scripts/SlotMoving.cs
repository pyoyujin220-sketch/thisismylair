using UnityEngine;

public class SlotMoving : MonoBehaviour
{
    // 플레이어가 이동할 슬롯 위치들
    public Transform[] slots;

    public float fixedZ = 0.0f;
    public float fixedY = -2.9f;
    public float hiddenY = -4.5f;

    public bool bIsHidden = false;

    int currentSlot = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdatePosition();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            ChangeSlot(0);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            ChangeSlot(1);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            ChangeSlot(2);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleHide();
        }
    }

    // 슬롯 변경 (숨김 상태는 유지됨)
    void ChangeSlot(int index)
    {
        currentSlot = index;
        UpdatePosition();
    }

    void ToggleHide()
    {
        bIsHidden = !bIsHidden;

        UpdatePosition();
    }

    // 위치 계산 함수
    void UpdatePosition()
    {
        // 삼항 연산자 조건 ? 참 : 거짓;
        float targetY = bIsHidden ? hiddenY : fixedY;

        // 최종 위치 적용
        transform.position = new Vector3(
            slots[currentSlot].position.x,
            targetY,
            fixedZ);
    }
}
