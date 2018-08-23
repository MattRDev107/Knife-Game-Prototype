using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour {

    public float speed;
    public float Force;
    public float torqueForce;
    public Transform spawnPos;
    public AudioSource knifeHitTarget;
    public AudioSource knifeHitKnife;

    private int numberOfExits = 0;
    private float numOffire = 0;
    private float currentSpeed = 0.0f;
    private bool canParent = false;
    private bool fire;
    private Vector2 dir;

    private BoxCollider2D bc2d;
    private GameObject Target;
    private Rigidbody2D rb2d;
    private GameController gameController;
    private Score score;
    private GameOver gameOver;

    void Start() {
        gameOver = GameObject.Find("GameOver").GetComponent<GameOver>();
        score = GameObject.Find("Canvas").GetComponent<Score>();
        bc2d = GetComponent<BoxCollider2D>();
        spawnPos = GameObject.FindGameObjectWithTag("Spawn").transform;
        Target = GameObject.FindGameObjectWithTag("Targets");
        rb2d = GetComponent<Rigidbody2D>();
        gameController = GameObject.FindGameObjectWithTag("Spawn").GetComponent<GameController>();
    }


    void Update() {
        fire = (Input.touchCount >= 1 || Input.GetMouseButtonDown(0) ) && gameOver.knifeHitAnotherKnife == false;
        if (canParent) transform.parent = Target.transform;
    }

    void FixedUpdate() {
        if(rb2d.bodyType != RigidbodyType2D.Static) rb2d.AddForce(Vector2.up * currentSpeed);
        if (fire && numOffire <= 0.0f) {
            currentSpeed = speed;
            numOffire++;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        currentSpeed = 0.0f;
        if (collision.gameObject.name == "Target") {
            StopVelocity();
            rb2d.bodyType = RigidbodyType2D.Static;
            canParent = true;
            knifeHitTarget.Play();
            score.scoreNum++;
        } else if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Blockers"){
            rb2d.gravityScale = 1;
            rb2d.AddForce(Vector2.down * Force);
            rb2d.AddTorque(torqueForce);
            knifeHitKnife.Play();
            StopVelocity();
            bc2d.enabled = false;
            gameOver.knifeHitAnotherKnife = true;
        }
        if (numberOfExits <= 0) {
            Instantiate(gameController, spawnPos.position, Quaternion.identity);
            numberOfExits++;
        }
    }

    void StopVelocity() {
        rb2d.velocity = Vector3.zero;
    }
}
