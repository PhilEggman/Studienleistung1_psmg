using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {




    private Door door;
    private Collider TriggerZone_Open;



    public void setDoor(Door door)
    {
        this.door = door;
    }

    void OnTriggerEnter(Collider TriggerZone_Open)
    {
        this.TriggerZone_Open = TriggerZone_Open;
        door.open();
    }
}
