using UnityEngine;

public class AutoPipe : MonoBehaviour
{
    [SerializeField] GameObject pipeOBJ;
    [SerializeField] float height;
    [SerializeField] float time;
    void Start()
    {
        pipeOBJ = GameObject.Find("PipeFather");
    }

    // Update is called once per frame
    void Update()
    {   time += Time.deltaTime; 
        if(time > 2.5)
        {
            time = 0;
            GameObject obj = Instantiate(pipeOBJ, new Vector2(transform.position.x, transform.position.y + Random.Range(-height,height)), Quaternion.identity);
            Destroy(obj, 7);
        }
         
    }
}
