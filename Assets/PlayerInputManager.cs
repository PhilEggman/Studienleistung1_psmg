using UnityEngine;
using System.Collections;

public class PlayerInputManager : MonoBehaviour {

    public float rotationSpeed = 30f;
    public float speedBoost = 20;


    private string inputMovementAxisName;
    private string inputRotationAxisName;

    private float inputMovement;
    private float inputRotation;

    private Transform spwanPoint;

    private Rigidbody rigidbody;

    // Use this for initialization
     
    void Start() {
        Init(spwanPoint);
    }

    private void Move () {
        inputMovement = Input.GetAxis(inputMovementAxisName);
        Vector3 movement = transform.forward * speedBoost * inputMovement * Time.deltaTime;

        rigidbody.MovePosition(rigidbody.position + movement);
    }

    private void Rotation () {
        inputRotation = Input.GetAxis(inputRotationAxisName);

        float turn = inputRotation * rotationSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rigidbody.MoveRotation(rigidbody.rotation * turnRotation);
    }
	
	// Update is called once per frame
	void Update () {

        Move();
        Rotation();
	}

    public void Init (Transform spwanPoint) {

        this.spwanPoint = spwanPoint;

        inputMovementAxisName = "Vertical";
        inputRotationAxisName = "Horizontal";

        rigidbody = GetComponent<Rigidbody>();
    }

}
