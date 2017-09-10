using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	//This is a reference to the Rigidbody componernt called "rb"
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	// Use Start for initialization
	// Update is called once per frame
	// We marked this as "Fixed"Update because we
	// are using it to mess with physics

	void FixedUpdate () {
		// Add a force of amount of "forwardForce" on the z-axis
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d")) 
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("a")) 
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f) 
		{
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
