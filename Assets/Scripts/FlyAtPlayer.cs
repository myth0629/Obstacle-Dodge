using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 5f;
    Vector3 playerPosition;

    void Awake()   
    {   
        gameObject.SetActive(false);
    }

    void Start()
    {
        
    }

    void Update()
    {
        playerPosition = player.transform.position;
        OnDestroy();
        MoveToPlayer();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    void OnDestroy()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
