using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletL: MonoBehaviour
{
    public float speed;
    public float distance;
    public LayerMask isLayer;
    // Start is called before the first frame update
    //private Animator animator; //애니메이션 등록
    void Start()
    {
        Invoke("DestroyBullet", 2);
        //animator = GetComponent<Animator>();
        //animator.SetBool("isHunted", true);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, transform.right, distance, isLayer);
        if (ray.collider != null)
        {
            DestroyBullet();
        }
        transform.Translate(transform.right * -1 * speed * Time.deltaTime);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}