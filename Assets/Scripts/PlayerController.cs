using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float turnSpeed;

    [SerializeField] float acceleration;
    [SerializeField] float control;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        control = Input.GetAxis("Horizontal");
        acceleration = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * acceleration);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * control);
    }
}
