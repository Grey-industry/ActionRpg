using UnityEngine;

public class slimeBasic : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip hits_sound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            print("hit");
            audioSource.PlayOneShot(hits_sound);
        }
    }
}
