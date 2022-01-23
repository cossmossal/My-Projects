using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public gameOverScreen gameOverScreen;
    public Text scoreText;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;
    private int count;
    public HealthControl healthBar;
    private bool gameOver = false;
    public float speed;
    private float normalspeed = 1.2f;
    private float boostedspeed = 3.5f;
    private float timer;
    private float boostduration = 5f;
    private Animator anim;
    public Sword swordScript;
    public GameObject knightGeometry;

    internal object GetPosition()
    {
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        speed = normalspeed;
        rigidbodyComponent = GetComponent<Rigidbody>();
        count = 0;
        UpdateScoreText();
        swordScript = GameObject.Find("Sword").GetComponent<Sword>();

    }

    // Update is called once per frame
    void Update()
    {
        //Check if space key was pressed.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown("z"))
        {
            swordScript.isAttacking = true;
            anim.SetTrigger("Attack");

        }

    }
    private void FixedUpdate()
    {
        if (gameOver == false)
        {
            rigidbodyComponent.velocity = new Vector3(0, rigidbodyComponent.velocity.y, horizontalInput * speed);
            if (horizontalInput != 0)
            {
                anim.SetTrigger("isWalking");
                if (horizontalInput > 0)
                {
                    knightGeometry.transform.localRotation = new Quaternion(0, 0, 0, 0);
                }
                else
                {
                    knightGeometry.transform.localRotation = new Quaternion(0, 180, 0, 0);
                }
            }
            else
            {
                anim.ResetTrigger("isWalking");
            }
        }

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }
        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 7)
        {
            return;
        }
        if (jumpKeyWasPressed == true && gameOver == false)
        {
            AudioManagerScript.PlaySound("JumpSound");
            rigidbodyComponent.AddForce(Vector3.up * 6.3f, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
            gameOver = false;
        }
        if (timer >= 0)
        {
            timer = timer - 0.01f;
        }
        else
        {
            speed = normalspeed;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            AudioManagerScript.PlaySound("PickUpCoinSound");
            Destroy(other.gameObject);
            count++;
            UpdateScoreText();
        }
        else if (other.gameObject.layer == 7)
        {
            AudioManagerScript.PlaySound("PlayerHIT");
            if (healthBar)
            {
                healthBar.onTakeDamage(20);
            }
        }
        else if (other.gameObject.layer == 8)
        {
            AudioManagerScript.PlaySound("PlayerHIT");
            if (healthBar)
            {
                healthBar.onTakeDamage(50);
            }
        }
        else if (other.gameObject.layer == 9)
        {
            AudioManagerScript.PlaySound("PowerUpSoundEffect");
            Boost();
            Destroy(other.gameObject);
        }

        if (healthBar.health <= 0)
        {
            AudioManagerScript.StopSound();
            AudioManagerScript.PlaySound("DeathOfPlayer");
            GameOver();

            count = 0;
        }
        else if (other.gameObject.tag == "InstaDeath")
        {
            Debug.Log("Death by fall");
            GameOver();
        }

    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + count;
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverScreen.Setup(count);
    }
    private void Boost()
    {
        speed = boostedspeed;
        timer = boostduration;
    }

    
    }

