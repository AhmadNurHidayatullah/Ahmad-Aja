using UnityEngine;


public class Plant : MonoBehaviour
{
    public AudioSource shootAudio;
    public GameObject bulletPrefab;
    public float shootInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(Shoot), 0.5f, shootInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        shootAudio.Play();
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);


    }
}
