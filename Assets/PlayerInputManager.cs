using UnityEngine;
using System.Collections;

public class PlayerInputManager : MonoBehaviour {

    public float rotationSpeed = 30f;
    public float speedBoost = 20;

    private int m_playerID;

    private string m_inputMovementAxisName;
    private string m_inputRotationAxisName;

    private float m_inputMovement;
    private float m_inputRotation;

    private Transform m_spwanPoint;

    private Rigidbody m_rigidbody;

    // Use this for initialization
     
    void Start() {
        Init(m_spwanPoint);
    }

    private void Move () {
        m_inputMovement = Input.GetAxis(m_inputMovementAxisName);
        Vector3 movement = transform.forward * speedBoost * m_inputMovement * Time.deltaTime;

        m_rigidbody.MovePosition(m_rigidbody.position + movement);
    }

    private void Rotation () {
        m_inputRotation = Input.GetAxis(m_inputRotationAxisName);

        float turn = m_inputRotation * rotationSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        m_rigidbody.MoveRotation(m_rigidbody.rotation * turnRotation);
    }
	
	// Update is called once per frame
	void Update () {

        Move();
        Rotation();
	}

    public void Init (Transform m_spwanPoint) {

        this.m_spwanPoint = m_spwanPoint;

        m_inputMovementAxisName = "Vertical";
        m_inputRotationAxisName = "Horizontal";

        m_rigidbody = GetComponent<Rigidbody>();
    }

}
