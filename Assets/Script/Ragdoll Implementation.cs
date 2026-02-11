using UnityEngine;

public class RagdollImplementation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animator animator;
    Rigidbody[] rigidbodies;
    Collider[] colliders;

    void Start()
    {
        rigidbodies = GetComponentsInChildren<Rigidbody>();
        colliders = GetComponentsInChildren<Collider>();
        DisableRagdoll();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            EnableRagdoll();
        }
    }
    public void EnableRagdoll()
    {
        animator.enabled = false;
        foreach (Rigidbody rb in rigidbodies)
            rb.isKinematic = false;
        foreach (Collider col in colliders)
            col.enabled = true;
    }

    void DisableRagdoll()
    {
        foreach (Rigidbody rb in rigidbodies)
            rb.isKinematic = true;
        foreach (Collider col in colliders)
            col.enabled = false;
    }
}
