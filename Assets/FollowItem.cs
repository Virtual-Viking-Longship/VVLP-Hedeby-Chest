using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowItem : MonoBehaviour
{
    public Transform item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = item.transform.position + new Vector3(0,0.05f,-0.05f);
    }
}
