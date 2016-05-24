using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {


    void Start()
    {
        GameObject triggerZone = transform.parent.Find("MazePowerConsole (1)").gameObject.transform.Find("TriggerZone_Open").gameObject;
        triggerZone.GetComponent<DoorTrigger>().setDoor(this);
    }

    void Update()
    {

    }

    public void open() {
        transform.position = Vector3(transform.position.x, 0, transform.position.z);
        
    }

    public void close() {
        transform.position = Vector3(transform.position.x, 3, transform.position.z);
    }
}
