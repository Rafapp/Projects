using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralAnimation : MonoBehaviour
{
    private Quaternion cachedRotation;
    private ConfigurableJoint joint;
    public Transform targetRotation;
    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        cachedRotation = joint.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        ConvertJointRotations.SetTargetRotationLocal(joint, targetRotation.rotation, cachedRotation);
    }
}
