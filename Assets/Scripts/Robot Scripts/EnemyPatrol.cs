using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    private Tweener tweener;
    float smooth = 5.0f;
    float tiltAngle = -90.0f;
    [SerializeField]
    private GameObject item;
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
        if (item.transform.position == new Vector3(-7f, 3f))
        {
            item.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-7f, -9f), 1.0f);

        }
        if (item.transform.position == new Vector3(-7f, -9f))
        {
            item.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-10f, -9f), 1.0f);
        }
        if (item.transform.position == new Vector3(-10f, -9f))
        {
            item.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-10f, 3f), 1.0f);
        }
        if (item.transform.position == new Vector3(-10f, 3f))
        {
            item.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
            tweener.AddTween(item.transform, item.transform.position, new Vector3(-7f, 3f), 1.0f);
        }
    }

}