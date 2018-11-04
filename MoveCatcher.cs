using UnityEngine;
using System.Collections;

public class MoveCatcher : MonoBehaviour {

	public int speed = 2;
	public int score = 0;
	public string label;
	//public int percentage;
	//private static int breadCount;

	//SpawnBread b;
	//GameObject bread;

	//breadCount = b.breadCount;
	/* 
	void Start(){
	    b = GameObject.Find("Bread").GetComponent<SpawnBread>();
        breadCount = b.GetBreadCount();
	} */

	//Object currentPlayer;

	void Start(){
		//label = null;
		//currentPlayer = gameObject;

		if(GameObject.FindGameObjectsWithTag("Player").Length > 1) 
			{
				Destroy(gameObject);
			}
	}
	
	void Awake(){
		DontDestroyOnLoad(this);
	}

	void Update () {

		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		//percentage = score / breadCount * 100;

		
	}


	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bread"))
        {
			score++;
            Destroy(other.gameObject);
			Debug.Log("Score: " + score);
        }
    }

	 void OnGUI() {
        //GUI.Button(new Rect(2,100,100,100), scoreText);
		label = "Score: " + score.ToString();
		GUILayout.Label(label);
		// " Percentage: " + percentage.ToString() + "%");
    } 

}
