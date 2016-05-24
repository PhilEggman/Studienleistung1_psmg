using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {


    void Start()
    {
        
    }

    public void open() {
        Vector3 Movement = new Vector3(transform.position.x, 0, transform.position.z);
        
    }

    public void close() {
        transform.position = new Vector3(transform.position.x, 3, transform.position.z);
    }
}
