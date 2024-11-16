using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering.Universal;
/// <summary>
/// Weapon System 
/// </summary>
public class WeaponSystem : MonoBehaviour
{
    [SerializeField, Header("�l�u�ͦ��I")]
    private Transform point;
    [SerializeField, Header("�l�u�w�m��")]
    private GameObject prefabBullet;
    [SerializeField, Header("�l�u�t��"), Range(0, 2000)]
    private int bulletSpeed = 1000;


    public void Fire()
    {
        // �ͦ����� Instantiate(Class, Position, Angle)
        GameObject temp = Instantiate(prefabBullet, point.position, Quaternion.identity);
        temp.GetComponent<Rigidbody>().AddForce(point.forward * bulletSpeed);
    }
}
