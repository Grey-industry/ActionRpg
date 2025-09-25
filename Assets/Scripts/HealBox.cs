using UnityEngine;

public class HealBox : MonoBehaviour
{
    private Gameplay sm;
    public AudioSource Heal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sm = Object.FindFirstObjectByType<Gameplay>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sm.Heal();
            Debug.Log("Hello");
            Destroy(gameObject);
            Heal.Play();
        }
    }
}
