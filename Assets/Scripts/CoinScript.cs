using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject coin;
    public float spawnRate = 2;

    public float maxright;
    public float maxleft;
    public float maxtop;
    public float maxbottom;

    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        createCoin();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            createCoin();
            timer = 0;
        }

    }


    // instatiating coins with random positions 
    void createCoin()
    {
        Instantiate(coin, new Vector3(Random.Range(maxleft, maxright), Random.Range(maxtop, maxbottom), 0), transform.rotation);
    }

}
