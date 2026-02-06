using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Sprite idleSprite;
    public Sprite attackSprite;
    public Sprite coverSprite;

    SpriteRenderer sr;

    // 공격 후 공격 스프라이트를 유지하고 있는 시간
    public float attackTime = 0.4f;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sortingOrder = 4;
    }

    public void SetIdle()
    {
        sr.sprite = idleSprite;
    }

    public void SetAttack()
    {
        sr.sprite = attackSprite;
        Invoke("SetIdle", 0.5f);
    }

    public void SetCover()
    {
        sr.sprite = coverSprite;
    }
}
