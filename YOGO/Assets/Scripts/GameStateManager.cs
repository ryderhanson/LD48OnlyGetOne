using UnityEngine;
using System.Collections;

public class GameStateManager : MonoBehaviour 
{
	public float maxTime;
	private float currentTime = 0.0f;
	private bool roundOver = false;

	private static bool countingDown = false;

	private static bool reset = false;

	private static int numBlocksBroken = 0;

	void Awake()
	{
		//DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(reset)
		{
			currentTime = 0.0f;
			reset = false;
		}

		if(countingDown)
		{
			currentTime += Time.deltaTime;

			if(currentTime >= maxTime)
			{
				currentTime = 0.0f;
				countingDown = false;
				EndRound();
			}
		}
	}

	void OnGUI()
	{
		if(roundOver)
		{
			GUI.TextArea( new Rect(Screen.width / 2.0f - 20.0f, Screen.height / 2.0f - 80.0f, 120.0f, 40.0f ), "Game Over. You scored " + numBlocksBroken);

			if(GUI.Button( new Rect(Screen.width / 2.0f - 80.0f, Screen.height / 2.0f, 80.0f, 40.0f ), "Retry"))
			{
				roundOver = false;
				numBlocksBroken = 0;
				Application.LoadLevel("MainScene");
			}
			if(GUI.Button( new Rect(Screen.width / 2.0f + 80.0f, Screen.height / 2.0f, 80.0f, 40.0f ), "Quit"))
			{
				Application.Quit();
			}
		}
	}

	public static void ShotFired()
	{
		countingDown = true;
	}

	public static void BlockBroken()
	{
		numBlocksBroken++;
	}

	public static void ResetCountdown()
	{
		reset = true;
	}

	void EndRound()
	{
		roundOver = true;
	}
}
