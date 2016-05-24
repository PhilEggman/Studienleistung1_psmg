using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {




    private Door door;

    public void setDoor(Door door)
    {
        this.door = door;
    }

    void OnTriggerEnter()
    {
        door.open();
    }
}
