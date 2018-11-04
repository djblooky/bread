using UnityEngine;
using System.Collections;

public class ScoreBoard : MonoBehaviour {

	int score;
	public string scoreText;

	void start() {
		score = 0;
        scoreText = "Score: " + score.ToString();
	}

	void Update () {
        scoreText = "Score: " + score.ToString();
    }


	void OnBecameInvisible() {
        Destroy(gameObject);
    }


    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            score += 1;
            Destroy(this.gameObject);
        }
    }

   
}
