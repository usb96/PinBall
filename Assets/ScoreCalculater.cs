using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculater : MonoBehaviour {

	//TotalScoreを表示するText
	private GameObject totalScoreText;
	
	//総合点数
	private int totalScore = 0;
	//SmallStarの点数
	private int smallstarScore = 5;
	//LargeStarの点数
	private int largestarScore = 15;
	//SmallCloudの点数
	private int smallcloudScore = 10;
	//LargeCloudの点数
	private int largecloudScore = 20;

	// Use this for initialization
	void Start () {
		this.totalScoreText = GameObject.Find("TotalScoreText");
	}
	
	// Update is called once per frame
	void Update () {
		this.totalScoreText.GetComponent<Text>().text = "Score:" + totalScore.ToString();
	}

	//オブジェクト衝突時に点数を更新する
	void OnCollisionEnter(Collision other){
		
		switch(other.gameObject.tag)
		{
			case "SmallStarTag" :
			totalScore += smallstarScore;
			break;
			
			case "LargeStarTag":
			totalScore += largestarScore;
			break;

			case "SmallCloudTag":
			totalScore += smallcloudScore;
			break;

			case "LargeCloudTag":
			totalScore += largecloudScore;
			break;

			default:
			break;
		}
	}
}
