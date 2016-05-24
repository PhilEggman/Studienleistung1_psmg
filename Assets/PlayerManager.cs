using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    private int healthPoint;
    private float speedBoost;

    public int HealthPoint
    {
        get
        {
            return healthPoint;
        }

        set
        {
            healthPoint = value;
        }
    }

    public int SpeedBoost
    {
        get
        {
            return speedBoost;
        }

        set
        {
            speedBoost = value;
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
