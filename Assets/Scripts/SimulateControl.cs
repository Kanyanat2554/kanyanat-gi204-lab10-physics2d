using UnityEngine;

public class SimulateControl : MonoBehaviour
{
    Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.simulated = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            rb.simulated = !rb.simulated;
        }
    }
    

    
}
