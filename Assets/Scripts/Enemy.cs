using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Transform player;   // ผู้เล่น
    public float speed = 3f;   // ความเร็วศัตรู

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            // เดินเข้าหาผู้เล่น
            transform.position = Vector3.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );

            // หันหน้าไปหาผู้เล่น
            Vector3 direction = (player.position - transform.position).normalized;
            transform.forward = direction;
        }
    }
}




