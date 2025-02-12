using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {

        transform.position = transform.position + Vector3.left * speed ;

    }
}
