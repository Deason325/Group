using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public Rigidbody2D rb;
	public float movespeed;
	public float jumpheight;
	public bool jump;
	public int count;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool onGround;
	private Animator anim;
	public float force;
	public bool jumpleft;
	public bool fall = false;


	public bool onLadder;
	public float climbSpeed;
	private float climbVelocity;
	private float gravityStore;

	public GameObject player;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		gravityStore = rb.gravityScale;
	}
	void FixedUpdate()
	{
		onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}

	void Update () {
		if(onLadder && Input.GetKeyDown(KeyCode.UpArrow)){
			rb.gravityScale = 0.0f;
			climbVelocity = climbSpeed;
			//climbVelocity = climbSpeed * Input.GetAxisRaw ("Vertical");
			rb.velocity = new Vector2 (rb.velocity.x, climbVelocity);
		}
		if(onLadder && Input.GetKeyDown(KeyCode.DownArrow)){
			/*r_body.gravityScale = 0.0f;
			climbVelocity = -climbSpeed * Input.GetAxisRaw ("Vertical");
			r_body.velocity = new Vector2 (r_body.velocity.x, climbVelocity);*/
			rb.gravityScale = gravityStore/4;
		}
		if (!onLadder) {
			rb.gravityScale = gravityStore;
		}


		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rb.velocity = new Vector2(-movespeed, rb.velocity.y);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			rb.velocity = new Vector2(movespeed, rb.velocity.y);
		}
		if (onGround)
		{
			anim.SetBool ("jump", false);
			anim.SetBool ("run", false);
			anim.SetBool ("runleft", false);
			anim.SetBool("jumpleft", false);
			if (Input.GetKey (KeyCode.UpArrow)) {
				rb.velocity = new Vector2 (rb.velocity.x, jumpheight);
				anim.SetBool("jump", true);
				if (anim.GetBool("runleft") == true ){
					anim.SetBool("jumpleft", true);
				}
			}
		}
		if (jump)
		{
			rb.velocity = new Vector2(rb.velocity.x, jumpheight);
			jump = false;
		}
		if (rb.velocity.x != 0 && onGround) {
			if (Input.GetKey (KeyCode.RightArrow)) {
				anim.SetBool ("run", true);
				anim.SetBool ("runleft", false);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				anim.SetBool ("run", false);
				anim.SetBool ("runleft", true);

			} 
		}

	}
	public void changespeed(float amount){
		movespeed = amount;	
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.tag == "movingPlatform") {
			transform.parent = other.transform;
		}
	}

	void OnCollisionExit2D(Collision2D other){
		if (other.transform.tag == "movingPlatform") {
			transform.parent = null;
		}
	}

	/*public void Die(){
		//Debug.Log ("Player died. Current hp" + health);
		//GetComponent<AudioSource> ().Play ();
		Object.Destroy (this.gameObject, 1.0f);
		Invoke ("load", 2);
		Application.LoadLevel (Application.loadedLevel);
		//Application.LoadLevel (Application.loadedLevel);
		//UnityEngine.SceneManagement.SceneManager.LoadScene (
		//	UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
	}*/

}	
