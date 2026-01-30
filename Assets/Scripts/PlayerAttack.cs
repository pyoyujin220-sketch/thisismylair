using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("Projectile")]
    public GameObject projectilePrefab;

    [Header("Fire Point")]
    public Transform firePoint;   // 직접 지정

    [Header("References")]
    public CrosshairFollow crosshairFollow;

    Camera mainCamera;

    void Awake()
    {
        mainCamera = Camera.main;
    }

    void Fire()
    {
        Vector2 crosshairPos = crosshairFollow.GetCrosshairScreenPosition();
        Ray ray = mainCamera.ScreenPointToRay(crosshairPos);

        // 발사 이펙트
        GameObject bullet = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
        bullet.GetComponent<Projectile>().Init(ray.direction);

        // 데미지 판정 (즉시)
        if (Physics.Raycast(ray, out RaycastHit hit, 100f))
        {
            Health hp = hit.collider.GetComponent<Health>();
            if (hp != null)
            {
                hp.TakeDamage(20f);
            }
        }
    }





    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
}
