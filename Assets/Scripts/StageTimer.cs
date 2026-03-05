using UnityEngine;
using TMPro; // TextMeshPro 사용 시
using UnityEngine.Events;

public class StageTimer : MonoBehaviour
{
    [SerializeField] private float remainingTime = 10f; // 시작 시간
    [SerializeField] private TMP_Text timerText;       // UI 텍스트
    public UnityEvent onTimerEnd;                    // 시간이 끝났을 때 실행할 이벤트

    private bool isTimerRunning = true;

    void Update()
    {
        if (!isTimerRunning) return;

        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            remainingTime = 0;
            isTimerRunning = false;
            UpdateTimerDisplay();

            // 지정된 함수들을 실행!
            onTimerEnd?.Invoke();
        }
    }

    void UpdateTimerDisplay()
    {
        // 시간을 00:00 형식으로 표시
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}