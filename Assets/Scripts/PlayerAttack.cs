using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    [Header("Projectile")]
    public GameObject projectilePrefab;

    [Header("References")]
    public CrosshairFollow crosshairFollow;

    Transform firePoint;
    Camera mainCamera;

    void Awake()
    {
        // 메인 카메라 탐색
        mainCamera = Camera.main;

        // firePoint 자동 생성 / 탐색
        firePoint = transform.Find("FirePoint");

        if( firePoint == null )
        {
            GameObject fp = new GameObject("FirePoint");
            fp.transform.SetParent(transform);
            fp.transform.localPosition = Vector3.zero;
            firePoint = fp.transform;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Fire()
    {
        // 크로스헤어 화면 좌표
        Vector2 mouseScreenPos = crosshairFollow.GetCrosshairScreenPosition();

        // 화면을 월드 좌표로
        Vector3 mouseWorldPos = mainCamera.ScreenToWorldPoint(mouseScreenPos);
        mouseWorldPos.z = 0.0f;

        // 발사 방향 계산
        Vector2 dir = (mouseWorldPos-firePoint.position).normalized;

        // 투사체 생성
        GameObject bullet = Instantiate(
            projectilePrefab,
            firePoint.position,
            Quaternion.identity
            );

        // 뱡향 전달
        bullet.GetComponent<Projectile>().Init(dir);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
}
