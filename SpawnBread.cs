using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SpawnBread : MonoBehaviour {

	public static int xMin = 5;
	public static int xMax = 13;
	public int rand;

	public int breadCount = 10;

	public GameObject bread; //prefab
	BreadMove clones;

	//public MoveCatcher mover;

	void Start () {
		
		//mover = GameObject.Find("Catcher").GetComponent<MoveCatcher>();

		breadCount = Random.Range(5,10);

		//set clone to current clone, change name, then find clone at index
		for(int i = 0; i < breadCount; i++){
			rand = Random.Range(xMin, xMax); //yee haw
			Object clone = Instantiate(bread, new Vector3(rand,9,0), Quaternion.identity); //set random x val of each BREAD
			clone.name = "Bread" + (i + 1).ToString();
			clones = GameObject.Find(clone.name).GetComponent<BreadMove>(); //find bread in game
			clones.speed = Random.Range(5,10); //set speed of each bread
			//breadCount++; //infinite bread
		}
		
	}

	void Update(){

		if(clones == null){
	
			SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
		}
		
	}

}

