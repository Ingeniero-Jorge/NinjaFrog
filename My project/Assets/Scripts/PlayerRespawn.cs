using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;

    private float checkPointPositionX, checkPointPositionY;

    public Animator animator;
    void Start()
    {
        life = hearts.Length;

        if (PlayerPrefs.GetFloat("checkPointPositionX") != 0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    private void CheckLife()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
            animator.Play("HitAnimation");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
            animator.Play("HitAnimation");
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
            animator.Play("HitAnimation");
        }
    }

    public void ReachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX", x);
        PlayerPrefs.SetFloat("checkPointPositiony", y);

    }

    public void PlayerDamaged()
    {
        life--;
        CheckLife();
    }
   
}
