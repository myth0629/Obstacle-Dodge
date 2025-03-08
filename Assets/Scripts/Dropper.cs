using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    Rigidbody rigidbody;
    MeshRenderer meshRenderer;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            //Debug.Log("LookOut");
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
