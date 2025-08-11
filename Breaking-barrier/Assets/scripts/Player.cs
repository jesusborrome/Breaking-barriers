using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Player : MonoBehaviour
{
    public float velocidade;
    public float forcapulo;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal")),0f,0f);
        transform.position += movement * Time.deltaTime * velocidade;
    }
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    private void ()
    {
        
    }
}
