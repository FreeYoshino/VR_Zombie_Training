using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering.Universal;
/// <summary>
/// Weapon System 
/// </summary>
public class WeaponSystem : MonoBehaviour
{
    [SerializeField, Header("子彈生成點")]
    private Transform point;
    [SerializeField, Header("子彈預置物")]
    private GameObject prefabBullet;
    [SerializeField, Header("子彈速度"), Range(0, 2000)]
    private int bulletSpeed = 1000;


    public void Fire()
    {
        // 生成物件 Instantiate(Class, Position, Angle)
        GameObject temp = Instantiate(prefabBullet, point.position, Quaternion.identity);
        temp.GetComponent<Rigidbody>().AddForce(point.forward * bulletSpeed);
    }
}
