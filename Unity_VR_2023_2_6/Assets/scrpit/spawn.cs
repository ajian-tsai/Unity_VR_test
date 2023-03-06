using UnityEngine;

public class spawn : MonoBehaviour
{
    [Header("生成物件")]
    public GameObject spawnBall;
    [Header("生成位置")]
    public Transform spawnPoint;

    public void Spawn()
    {
        Instantiate(spawnBall, spawnPoint.position, spawnPoint.rotation);
       //生成 ( 物件 、 物件位置 、 物件的旋轉值 )
    }
}
