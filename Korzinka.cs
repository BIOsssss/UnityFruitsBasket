using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korzinka : MonoBehaviour
{
    //Кнопки
    public List<KeyCode> leftButton;
    public List<KeyCode> rightButton;

    //Скорость
    public float playerSpeed = 2.0f;
    private float currentSpeed = 0.0f;

    //Рамки
    public float max_x;
    public float min_x;

    private Vector3 lastMovement = new Vector3();

    //Очко
    private int score = 0;
    public UnityEngine.UI.Text scoreText;
    public GameOverScreen gameOverScreen;
    public HeartSystem hs;

    public void GameOver(){
        gameOverScreen.Setup(score);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector3 movement = new Vector3();
        movement += MoveIfPressed(leftButton, Vector3.left);
        movement += MoveIfPressed(rightButton, Vector3.right);
        movement.Normalize();
        if (movement.magnitude > 0)
        {
            if(this.transform.position.x > max_x)
            {
                this.transform.position = new Vector3(max_x, this.transform.position.y, this.transform.position.z);
            }
            else if (this.transform.position.x < min_x)
            {
                this.transform.position = new Vector3(min_x, this.transform.position.y, this.transform.position.z);
            }
            else
            {
                currentSpeed = playerSpeed;
                this.transform.Translate(movement * Time.deltaTime * playerSpeed, Space.World);
                lastMovement = movement;
            }
        }
        else
        {
            this.transform.Translate(lastMovement * Time.deltaTime * currentSpeed, Space.World);
            currentSpeed *= 0.9f;
        }
    }

    Vector3 MoveIfPressed(List<KeyCode> keyList, Vector3 Movement)
    {
        foreach (KeyCode element in keyList)
        {
            if (Input.GetKey(element))
            {
                return Movement;
            }
        }
        return Vector3.zero;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Banana")){
            IncreaseScore(10); 
        }
        else if(other.CompareTag("Orange")){
            IncreaseScore(30); 
        }
        else if(other.CompareTag("Apple")){
            IncreaseScore(20); 
        }
        else if(other.CompareTag("Heart")){
            hs.health++;
        }
    }

    public void IncreaseScore(int increase){
        score += increase;
        scoreText.text = "Score: " + score;
    }
}
