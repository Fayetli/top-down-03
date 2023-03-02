using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public HUD hud;
    private int coins = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            coins++;
            hud.UpdateScore(coins);
            GameObject coin = collision.gameObject;
            AudioSource audioSource = coin.GetComponent<AudioSource>();
            audioSource.Play();

            coin.GetComponent<SpriteRenderer>().enabled = false;
            collision.enabled = false;

            print($"coins: {coins}");
        }
    }
}
