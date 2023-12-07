using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowItem : MonoBehaviour
{
    public Transform item;
    public float smoothSpeed = 0.125f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 itemPos = item.transform.position + new Vector3(0,0.05f,-0.05f);
        Vector3 smoothPos = Vector3.Lerp(transform.position, itemPos, smoothSpeed);
        transform.position = smoothPos;
    }
}
