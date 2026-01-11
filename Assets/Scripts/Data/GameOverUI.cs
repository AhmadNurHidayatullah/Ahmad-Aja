using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI killText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        killText.text = "ZOMBIE KILLED: " + GameData.zombieKilled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
