using UnityEngine;

public class TargetingSystem : MonoBehaviour
{
    [Header("Crosshair")]
    public RectTransform crosshair;

    [Header("Targeting")]
    public float maxScreenDistance = 120f;

    public Health GetTarget()
    {
        Health[] targets = Object.FindObjectsByType<Health>(
       FindObjectsSortMode.None);


        Health closest = null;
        float minDist = Mathf.Infinity;

        foreach (Health h in targets)
        {
            // 화면 뒤에 있으면 제외
            Vector3 screenPos = Camera.main.WorldToScreenPoint(h.transform.position);
            if (screenPos.z < 0)
                continue;

            float dist = Vector2.Distance(crosshair.position, screenPos);

            if (dist < minDist && dist <= maxScreenDistance)
            {
                minDist = dist;
                closest = h;
            }
        }

        return closest;
    }
}
