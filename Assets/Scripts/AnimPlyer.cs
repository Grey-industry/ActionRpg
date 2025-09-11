using UnityEngine;

public class AnimPlyer : MonoBehaviour
{
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Slime") && Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Debug.Log("Hello");
            animator.SetBool("Kick", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Slime"))
        {
            animator.SetBool("Kick", false);
        }
    }
}
