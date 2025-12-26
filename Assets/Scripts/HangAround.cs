using UnityEngine;

public class hang_around : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 2.0f;

    public float leftLimit = -4.0f;
    public float rightLimit = 4.0f;

    float fixedY;

    int direction = -1;

    void Start()
    {
        fixedY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x += direction * moveSpeed * Time.deltaTime;
        pos.y = fixedY;

        if (pos.x >= rightLimit)
        {
            direction = -1;
        }
        if(pos.x<=leftLimit)
        {
            direction = 1;
        }

        transform.position = pos;
    }
}
