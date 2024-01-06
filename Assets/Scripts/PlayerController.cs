using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour{
    public float rotationSpeed = 8f;
    public float thrustSpeed = 5f;
    public GameObject gun = null;
    public GameObject bulletPrefab = null;
    private Vector2 _thrustDirection;
    private Rigidbody _rigidBody;
    public static int score = 0;
    public ScoreManager scoreManager;

    void Start() {
        _rigidBody = this.gameObject.GetComponent<Rigidbody>();
    }

    void Update() {
        float rotation = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        float thrust = Input.GetAxis("Vertical");

         if(Input.GetKeyDown(KeyCode.Space)) {
            GameObject bullet = Instantiate(bulletPrefab, gun.transform.position, gun.transform.rotation);
         }

        _thrustDirection = transform.right;

        transform.Rotate(Vector3.forward, -rotation);
        _rigidBody.AddForce(_thrustDirection * thrust * thrustSpeed);

        if(score == 10) {
            scoreManager.AddScore(new Score("PlayerX", score));
            SceneManager.LoadScene("End");
        }
    }

    private void OnCollisionEnter(Collision coll) {
        if(coll.gameObject.tag.Equals("Enemy")) {
            scoreManager.AddScore(new Score("PlayerX", score));
            score = 0;
            SceneManager.LoadScene("Game");
        }
    }
}
