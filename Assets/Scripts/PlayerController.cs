using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public float turnSpeed = 3f;
    public float horizontalInput;
    public float forwardInput;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

    }
}
