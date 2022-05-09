using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    private Tweener tweener;
    //float smooth = 5.0f;
    //float tiltAngle = -90.0f;
    private Vector3 startPosition;
    private Vector3 secondPosition;
    //private Vector3 thirdPosition;
    //private Vector3 fourthPosition;
    [SerializeField]
    private GameObject item;
    
    void Start()
    {
        tweener = GetComponent<Tweener>();
        startPosition = item.transform.position;
        secondPosition = new Vector3(item.transform.position.x, item.transform.position.y - 9);
    }

    // Update is called once per frame
    void Update()
    {
        //float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        //Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
        if (item.transform.position == startPosition)
        {
            //item.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
            tweener.AddTween(item.transform, item.transform.position, secondPosition, 1.0f);

        }

        if (item.transform.position == secondPosition)
        {
            //item.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
            tweener.AddTween(item.transform, item.transform.position, startPosition, 1.0f);

        }


    }

}