using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHP = 100.0f;
    public float currentHP;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        // Mathf.Clamp(°ª, ÃÖ¼Ú°ª, ÃÖ´ñ°ª);
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);

        if (currentHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public float GetHPRatio()
    {
        return currentHP / maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
