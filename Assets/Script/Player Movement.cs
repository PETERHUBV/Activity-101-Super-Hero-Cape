using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 3;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(X,0,Z);
        transform.Translate(move * Speed * Time.deltaTime,Space.World);

        animator.SetFloat("MoveX", X);
        animator.SetFloat("MoveZ", Z);
        animator.SetFloat("Speed", move.magnitude);
    }
}
