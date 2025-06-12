using UnityEngine;

public class Platforms : MonoBehaviour
{
    private PlatformEffector2D effector;

    public float startWaiTime;

    private float waitedTime;
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp("s"))
        {
            waitedTime = startWaiTime;
        }


        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            if(waitedTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitedTime = startWaiTime;
            }
            else
            {
                waitedTime -= Time.deltaTime; 
            }
        }
        if (Input.GetKey("space"))
        {
            effector.rotationalOffset = 0;
        }
    }
}
