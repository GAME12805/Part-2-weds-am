using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject myPrefab;
    Vector3 myPosition;
    Quaternion myRotation;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newthing = Instantiate(myPrefab, myPosition, myRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
