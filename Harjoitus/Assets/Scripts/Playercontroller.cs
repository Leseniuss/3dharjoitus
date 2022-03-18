using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{

    [SerializeField]
    float playerSpeed;
    [SerializeField]
    float jumpForce;
    [SerializeField]
    GameManager gm;


    public Collider[] colliders;

    float horizontalInput;
    float verticalInput;

    Vector3 direction;
    Vector3 startPos;
    bool jumping = false;
    // bool SceneFinished;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        gm = GameObject.Find("environment").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            CalculateMovement();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            jumping = true;
        }
    }

    private void FixedUpdate()
    {
        colliders = Physics.OverlapSphere(transform.position + new Vector3(0, -0.4f, 0), 1f);

        if (jumping && colliders.Length > 1)
        {
            Jump();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            gameObject.transform.position = startPos;
            gm.DecreasePoints();
        }
    }

   // private void OnTriggerEnter(Collider other)
   // {
     //   if (other.tag == "Finish")
      //  {

            // SceneFinished = true;
        //    gm.Finish();


    //    }
   // }

    void CalculateMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        direction = new Vector3(horizontalInput, 0f, verticalInput);

        transform.Translate(direction * playerSpeed * Time.deltaTime);
    }

    void Jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        jumping = !jumping;
    }
}
