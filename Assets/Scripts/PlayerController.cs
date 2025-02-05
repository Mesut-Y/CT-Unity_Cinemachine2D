using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal"); //inputmanager ekranında tuş atamaları yapılmış.
        float yInput = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(xInput, yInput).normalized; //çapraz yönde hızı artmasın diye normalized yapıldı.

        player.linearVelocity = direction * 2f; //karakter hızı 2f ile arttırıldı.
    }
}
