using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class GameManager : MonoBehaviour {
	private ScoreData scoreData; 
	private List<List<GameObject>> notes;
	private float speed;
	private float time;
	private string title;
	private Level level;
	public AudioClip music;
	private AudioSource audioSource;
	void Start () {
		// 初期化
		scoreData = new ScoreData();
		notes = new List<List<GameObject>>();
		title = "砂の惑星";
		level = Level.HARD;
		audioSource = GetComponent<AudioSource>();

		// 譜面の読み込み
		var json = Resources.Load("Scores/" + title) as TextAsset;
		scoreData = JsonConvert.DeserializeObject<ScoreData>(json.text);

		// 曲の読み込み
		music = Resources.Load("Music/" + title) as AudioClip;
		audioSource.clip = music;

		// ノーツ生成


		// 曲の開始
		audioSource.PlayOneShot(audioSource.clip);

	}
	
	void Update () {
		// 可視状態ならノーツを移動
		
	}
}
