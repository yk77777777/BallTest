using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject monkey;
    Rigidbody rb;
    public float speed = 100f;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody>();
        Vector3 dir = monkey.transform.position - transform.position;
        dir.Normalize();
        rb.velocity = dir * speed;
    }

    // 物と物がぶつかったときの処理
    void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject, 0.1f);
        //何をどこにどの向きで
        Instantiate(explosion, 
        transform.position + Vector3.down * 9f, 
        Quaternion.identity);
        Destroy(gameObject, 0.1f);
    }
}
