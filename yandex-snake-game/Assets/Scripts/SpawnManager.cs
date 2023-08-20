using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Vector3 startPosition;

    public GameObject projectile;
    public GameObject enemy;
    
    
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 1f, 1.2f);
        InvokeRepeating("SpawnProjectilies", 2f, 3f);
    }

    
    void Update()
    {
        startPosition = new Vector2(Random.Range(19f, 21f), Random.Range(-3f, 3f));
        
    }
    
    private void SpawnProjectilies() 
    {
    
    	GameObject instance = (GameObject)Instantiate(projectile, startPosition, Quaternion.identity);
    	Destroy(instance, 6f);
    }
    
    
    private void SpawnEnemies() 
    {
    
    	GameObject instance = (GameObject)Instantiate(enemy, startPosition, Quaternion.identity);
    	Destroy(instance, 6f);
    
    }
    
   
}
