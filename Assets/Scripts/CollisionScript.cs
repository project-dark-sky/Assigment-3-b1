using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public LogicScript logic;
    public AudioClip coinSound;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // detecting any collision and detroy this object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        logic.addScore(1);
        Destroy(gameObject);
    }

}
