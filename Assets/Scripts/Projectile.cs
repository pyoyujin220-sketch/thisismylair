using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 15.0f;
    public float damage = 20.0f;
    public float lifeTime = 2f;

    Vector2 direction;

    public void Init(Vector2 dir)
    {
        direction = dir.normalized;
        Destroy(gameObject, lifeTime);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Health hp = other.GetComponent<Health>();
        if (hp != null)
        {
            other.SendMessage("TakeDamage", damage);
            Destroy(gameObject);
        }
    }
}
