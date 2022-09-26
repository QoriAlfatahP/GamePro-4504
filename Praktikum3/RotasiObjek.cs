using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotasiObjek : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 maju;
    Vector3 mundur;
    void Start()
    {
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler (mundur * 2 *Time.deltaTime);
    }
}