using System.Collections;
using UnityEngine;

public class MonsterBasic : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    public Sprite idleSprite;
    public Sprite skillSprite;

    public bool bIsPlayerHitable = false;
    private float _lastSkillTime;


    public enum MonsterClass {Archer, Astrologist, Debuffer, Healer, Magician, Reviver, Swordsman, Tanker};

    // Healer Reviver Archer Magician Tanker Astrologist Debuffer
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (spriteRenderer == null) spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        _lastSkillTime = Time.time;
        SetIdle();
    }

    [System.Serializable] // 인스펙터 창에서 수정할 수 있게 함.
    public struct MonsterData
    {
        public MonsterClass monsterClass;
        public float skillCoolTime;
        public float damage;
        public float attackSpriteContinueTime;
    }

    [Header("MosterDataSettings")]
    public MonsterData monsterData;

    private void Awake()
    {
        if (spriteRenderer == null) spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sortingOrder = 1;
    }

    void SetIdle() => spriteRenderer.sprite = idleSprite;
    

    void SetAttack() => spriteRenderer.sprite = skillSprite;
    

    public void ExecuteClassSkill()
    {
        Debug.Log("Use Class Skill");

        _lastSkillTime = Time.time;

        switch (monsterData.monsterClass)
        {
            case MonsterClass.Archer:
                Debug.Log("ArcherUsedItsSkill");
                SetAttack();

                break;
            case MonsterClass.Astrologist:
                Debug.Log("AstrologistUsedItsSkill");
                SetAttack();

                break;
            case MonsterClass.Debuffer:
                Debug.Log("DebufferUsedItsSkill");
                SetAttack();
                break;
            case MonsterClass.Healer:
                Debug.Log("HealerUsedItsSkill");
                SetAttack();
                break;
            case MonsterClass.Magician:
                Debug.Log("MagicianUsedItsSkill");
                SetAttack();
                break;
            case MonsterClass.Reviver:
                Debug.Log("ReviverUsedItsSkill");
                SetAttack();
                break;
            case MonsterClass.Swordsman:
                Debug.Log("SwordsmanUsedItsSkill");
                SetAttack();
                break;
            case MonsterClass.Tanker:
                Debug.Log("TankerUsedItsSkill");
                SetAttack();
                break;
        }
        Invoke(nameof(SetIdle), monsterData.attackSpriteContinueTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _lastSkillTime + monsterData.skillCoolTime + monsterData.attackSpriteContinueTime)
        {   
            ExecuteClassSkill();
        }
    }
}
