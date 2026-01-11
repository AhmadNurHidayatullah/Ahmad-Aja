using UnityEngine;

public class GameData : MonoBehaviour
{

    public static int zombieKilled;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Awake()
    {
        zombieKilled = PlayerPrefs.GetInt("ZombieKilled", 0);
    }

    public static void AddKill()
    {
        zombieKilled++;
        PlayerPrefs.SetInt("ZombieKilled", zombieKilled);
    }

    public static void ResetData()
    {
        zombieKilled = 0;
        PlayerPrefs.DeleteKey("ZombieKilled");
    }
}
