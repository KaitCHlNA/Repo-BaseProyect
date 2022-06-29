using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform gunSpawn;

    void Update()
    {
        ShootBullet();
    }

    void ShootBullet()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bulletPrefab, gunSpawn.position, transform.rotation);
        }
    }
}
