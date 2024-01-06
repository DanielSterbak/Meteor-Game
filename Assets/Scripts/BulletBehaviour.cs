using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletBehaviour : MonoBehaviour {
    public float speed = 10f;
    public float maxLifeTime = 3f;
    public Vector3 targetVector;
    private GameObject scoreText;
    void Start() {
        Destroy(gameObject, maxLifeTime);
        scoreText = GameObject.FindGameObjectWithTag("GameController");
    }

    void Update() {
        transform.Translate(speed * Time.deltaTime * targetVector);
    }

    private void OnCollisionEnter(Collision coll) {
        if (coll.gameObject.tag.Equals("Enemy")) {
            Destroy(gameObject);
            Destroy(coll.gameObject);
            IncreaseScore();
        }
    }
    
    public void IncreaseScore() {
        PlayerController.score++;
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + PlayerController.score;
    }
}