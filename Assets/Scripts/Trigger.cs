using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;
    [SerializeField] GameObject projectile4;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            projectile1.SetActive(true);
            projectile2.SetActive(true);
            projectile3.SetActive(true);
            projectile4.SetActive(true);
        }
    }
}
