using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    Vector3 maju;
    Vector3 mundur;
    public int aksi;
    void Start()
    {
            kekanan = new Vector3(1,0,0);
            kekiri = new Vector3(-1,0,0);
            keatas = new Vector3(0,1,0);
            kebawah = new Vector3(0,-1,0);
            maju = new Vector3(0,0,1);
            mundur = new Vector3(0,0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        switch(aksi){
            case 0:
                transform.position = transform.position + (kekanan * 2 * Time.deltaTime);
                break;
                
            case 1:
                transform.position = transform.position + (kekiri * 2 * Time.deltaTime);
                break;
            
            case 2:
                transform.position = transform.position + (keatas * 2 * Time.deltaTime);
                break;

            case 3:
                transform.position = transform.position + (kebawah * 2 * Time.deltaTime);
                break;

            case 4:
                transform.rotation = transform.rotation * Quaternion.Euler (maju * 2 *Time.deltaTime);
                break;

            case 5:
                transform.rotation = transform.rotation * Quaternion.Euler (mundur * 2 *Time.deltaTime);
                break;
        }
    }
}
