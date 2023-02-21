using System;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public static Bird Instance { get; private set; }

    [SerializeField] Rigidbody2D rigidbody2D;
    [SerializeField] float flapStrength;
    private const float deadZone = -20f;

    public event EventHandler OnGameOver;
    public event EventHandler OnScoreChanged;

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadZone)
        {
            OnGameOver?.Invoke(this, EventArgs.Empty);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = Vector2.up * flapStrength;
        }
    }

    // when Bird collision with Visable Pipe the game is over.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnGameOver?.Invoke(this, EventArgs.Empty);
    }

    // when Bird collision with middle invisable Pipe the score will update.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnScoreChanged?.Invoke(this, EventArgs.Empty);
    }

    public void SetFlapStrength(float flapStrength)
    {
        this.flapStrength = flapStrength;
    }
}
