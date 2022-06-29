using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 7f;
    public Vector3 bulletDirection;
    
    void Update()
    {
        transform.position += bulletDirection * bulletSpeed * Time.deltaTime;
        Destroy(gameObject, 2f);
    }
}
