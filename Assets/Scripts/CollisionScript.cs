using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public LogicScript logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.addScore(1);
        Destroy(gameObject);
    }

}
