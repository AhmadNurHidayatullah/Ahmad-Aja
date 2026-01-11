using UnityEngine;
using UnityEngine.SceneManagement;

public class Base : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
