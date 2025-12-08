using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Player;
    public float speed;

    private float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position); // Calculates distance between enemy and player
        Vector2 direction = Player.transform.position - transform.position; // Gets direction vector from enemy to player  

        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime); // Moves enemy towards player at a set speed
    }
}
