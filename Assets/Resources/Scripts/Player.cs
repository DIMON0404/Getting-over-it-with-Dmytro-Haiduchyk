using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    float cameraDistance = 3;
    GameObject head;
    Camera camera;
    GameObject hand;
    [Header("Сфера для привязки")]
    public SphereController sphereController;
    [Header("UI")]
    public UIController ui;
    

	// Use this for initialization
	void Start () {
        head = transform.Find("Head").gameObject;
        camera = head.transform.Find("Camera").GetComponent<Camera>();
        hand = transform.Find("Hand").gameObject;
        if (StaticData.pressContinue)
        {
            transform.position = StaticData._playerTransformPosition;
            transform.rotation = StaticData._playerTransformRotation;
            hand.transform.position = StaticData._handTransformPosition;
            hand.transform.rotation = StaticData._handTransformRotation;
            sphereController.isTied = StaticData.isTied;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (!ui._activeUI)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(transform.forward.x, 0, transform.forward.z), Time.deltaTime * 5);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position = Vector3.MoveTowards(transform.position, transform.position - new Vector3(transform.forward.x, 0, transform.forward.z), Time.deltaTime * 5);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(-transform.right.x, 0, -transform.right.z), Time.deltaTime * 5);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(transform.right.x, 0, transform.right.z), Time.deltaTime * 5);
            }

            float mouseY = Input.GetAxis("Mouse Y");
            transform.Rotate(0, Input.GetAxis("Mouse X") * 5, 0);
            hand.transform.Rotate(-mouseY * 10, 0, 0);

            if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                if (cameraDistance < 7)
                {
                    cameraDistance++;
                }
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                if (cameraDistance > 0)
                {
                    cameraDistance--;
                }
            }
            camera.transform.localPosition = new Vector3(0, cameraDistance, -cameraDistance);

            if (transform.position.y < -10)
            {
                transform.position = new Vector3(0, 100, 0);
            }
        }
        if (sphereController.isTied)
        {
            transform.position = transform.position + sphereController.pointTrigger - sphereController.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ui._activeUI = !ui._activeUI;

        }
	}

    public void SaveData()
    {
        StaticData._playerTransformPosition = transform.position;
        StaticData._playerTransformRotation = transform.rotation;
        StaticData._handTransformPosition = hand.transform.position;
        StaticData._handTransformRotation = hand.transform.rotation;
        StaticData.isTied = sphereController.isTied;
    }
}
