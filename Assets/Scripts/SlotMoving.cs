using UnityEngine;

public class SlotMoving : MonoBehaviour
{
    // 플레이어가 이동할 슬롯 위치들
    public Transform[] slots;

    public float fixedY = -2.9f;
    public float fixedZ = 0.0f;

    int currentSlot = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 게임 시작 시 가운데 슬롯으로 이동
        MoveToSlot(currentSlot);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            MoveToSlot(0);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            MoveToSlot(1);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            MoveToSlot(2);
        }
    }

    void MoveToSlot(int index)
    {
        // 슬롯 번호 저장
        currentSlot = index;

        // 플레이어 위치를 해당 슬롯 위치로 이동
        transform.position = new Vector3(
            slots[index].position.x,
            fixedY,
            fixedZ);
    }
}
