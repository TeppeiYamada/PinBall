using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour {

	private Text PointText;

	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		this.PointText = GameObject.Find ("PointText").GetComponent<Text>();
		this.PointText.GetComponent<Text>().text = score.ToString();

	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void OnCollisionEnter(Collision other){


		if(other.gameObject.tag == "SmallStarTag"){

			AddScore (10);

		}else if(other.gameObject.tag == "LargeStarTag"){

			AddScore (30);

		}else if (other.gameObject.tag == "SmallCloudTag"){

			AddScore (20);

		}else if(other.gameObject.tag == "LargeCloudTag"){

			AddScore (50);

		}

	}

	public void AddScore(int point){
	
		score = score + point;
		this.PointText.GetComponent<Text>().text = score.ToString();
	
	}


}
