using UnityEngine;

public class MonsterBasic : MonoBehaviour
{
    public Sprite idleSprite;
    public Sprite skillSprite;

    public bool bIsPlayerHitable = false;

    public SpriteRenderer spriteRenderer;
  
    public enum MonsterClass {Archer, Astrologist, Debuffer, Healer, Magician, Reviver, Swordsman, Tanker};

    // Healer Reviver Archer Magician Tanker Astrologist Debuffer
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public struct MonsterData
    {
        public MonsterClass monsterClass;
        public string className;
        public float skillCoolTime;
        public float damage;
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sortingOrder = 1;
    }

    void SetIdle()
    {
        spriteRenderer.sprite = idleSprite;
    }

    void SetAttack()
    {
        spriteRenderer.sprite = skillSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (!bIsPlayerHitable)
        {
            SetIdle();
        }
    }
}
