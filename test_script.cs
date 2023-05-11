using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_script : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bone_start;
    public GameObject bone_end;
    public GameObject keypoint_start;
    public GameObject keypoint_end;

    void Start()
    {
 

    }

    // Update is called once per frame
    void Update()
    {

        // set bone position to first keypoint
        bone_start.transform.position = keypoint_start.transform.position;

        // get the direction vectors
        Vector3 bone_direction = (bone_end.transform.position - bone_start.transform.position).normalized;
        Vector3 keypoint_direction = (keypoint_end.transform.position - keypoint_start.transform.position).normalized;

        // 
        Quaternion fromto = Quaternion.FromToRotation(bone_direction, keypoint_direction);
        bone_start.transform.rotation = fromto * bone_start.transform.rotation;
    }

}
