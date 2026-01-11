using UnityEngine;

public class Zombie : MonoBehaviour
{
    public AudioSource dieAudio;

    public float speed = 1f;
    public int health = 10;

    private bool isEating = false;
    private GameObject targetPlant;

    

    void Update()
    {
        if (!isEating)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Plant") && !isEating)
        {
            isEating = true;
            targetPlant = other.gameObject;

            Invoke(nameof(EatPlant), 1.5f);
        }
    }

    void EatPlant()
    {
        if (targetPlant != null)
        {
            Destroy(targetPlant);
        }

        ResumeWalk();
    }

    void ResumeWalk()
    {
        isEating = false;
        targetPlant = null;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            GameData.AddKill();
            AudioSource.PlayClipAtPoint(dieAudio.clip, transform.position);
            Destroy(gameObject);
        }
    }

}
