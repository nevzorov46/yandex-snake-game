using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    private static bool isFirstStart = true;

    public Text startText;
    public Text scoreText;
    public int score = 0;
    

    void Start()
    {
    
    	if (UIManager.isFirstStart)
    	{
    	    Time.timeScale = 0f;
            startText.enabled = true;
    	}
    	
    	else 
    	{
    	    Time.timeScale = 1f;
            startText.enabled = false;
    	
    	}
    		
    }

    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.Space) && UIManager.isFirstStart)
        {
            Time.timeScale = 1f;
            startText.enabled = false;
            scoreText.enabled = true;
            UIManager.isFirstStart = false;
            
        }
        
        scoreText.text = "Score: " + score.ToString();
    }
    
    public void RestartGame() 
    {
    	
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    	Time.timeScale = 1f;
    	startText.enabled = false;
    }
}
