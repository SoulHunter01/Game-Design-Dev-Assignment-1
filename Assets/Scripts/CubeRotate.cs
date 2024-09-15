using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{

    [SerializeField] float rotateSpeed = 50;
    [SerializeField] Vector3 axis = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.Rotate(axis * rotateSpeed * Time.deltaTime);
    }
}
