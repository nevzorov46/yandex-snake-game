using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    
    public float jumpForce = 15f;
    public UIManager uiManager;
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        uiManager = GameObject.Find("UICanvas").GetComponent<UIManager>();
    }

    
    void FixedUpdate()
    {	 
     	 if (Input.GetKeyDown(KeyCode.Space) || (Input.GetMouseButtonDown(0))) 
     	 {
     	    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
     	 }
    }
    
    private void OnTriggerEnter2D(Collider2D collider) 
    {
    	if (collider.tag == "Wall" || collider.tag == "Enemy") 
    	{
    	    uiManager.RestartGame();
    	
    	} else if (collider.tag == "Projectile")
    	
    	{
    	   Destroy(collider.gameObject);
   	   uiManager.score += 1;
    	}
    	 
    }
}
