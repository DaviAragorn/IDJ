using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float jumpPower;
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        var jump = Input.GetKey("space");

        if (jump)
        {
            transform.Translate(0, jumpPower, 0);
        }
        transform.Rotate(0, x, 0);
        transform.Translate(-z, 0, 0);
        

    }


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Interactable")
        {
            other.GetComponent<AudioSource>().Play();
            other.GetComponent<Renderer>().enabled = !other.GetComponent<Renderer>().enabled;

        }

    }

}
