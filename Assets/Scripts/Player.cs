using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float playerSpeed = 3.0f;
    private Rigidbody playerRb;

    public GameObject candle;
    public GameObject phone;
    public GameObject torchlight;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        candle.SetActive(false);
        phone.SetActive(false);
        torchlight.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        SwitchLight();
    }

    void MovePlayer()
    {
        float horizontalInput;
        horizontalInput = Input.GetAxis("Horizontal");

        // might change to rigidbody if necessary for the animated asset
        transform.Translate(Vector3.right * horizontalInput * playerSpeed * Time.deltaTime);

        // make player point light in the direction of travel
    }

    void SwitchLight()
    {
        // 1 2 3 or j k l
        //check if the light is on or off first
        // off the other lights before activating the selected one

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.J)) //candle
        {
            phone.SetActive(false);
            torchlight.SetActive(false);

            candle.SetActive(true);
        } 
        
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.K)) //phone
        {
            candle.SetActive(false);
            torchlight.SetActive(false);

            phone.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.L)) //torchlight
        {
            candle.SetActive(false);
            phone.SetActive(false);

            torchlight.SetActive(true);
        }
    }
}
