using UnityEngine;

public class EchoEffect : MonoBehaviour
{
    private float timeBetweenSpawns;
    
    public float startTimeBetweenSpawns = 0.5f;
    public GameObject tail;

    
    void Update()
    {
	if (timeBetweenSpawns <= 0)
	{
	     GameObject instance = (GameObject)Instantiate(tail, new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.4f), Quaternion.identity);
	     Destroy(instance, 2f);
	     timeBetweenSpawns = startTimeBetweenSpawns;
	} 
	    
	else  
	{
	     timeBetweenSpawns -= Time.deltaTime;
	}
     	
	  	
    }
}
