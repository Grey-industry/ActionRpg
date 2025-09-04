using UnityEngine;

public class SlimeTrigger : MonoBehaviour
{
    private Gameplay sm;

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
            sm.TakeDamage();
            Debug.Log("Hello");
        }
    }
}
