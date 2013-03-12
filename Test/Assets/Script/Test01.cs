using UnityEngine;
using System.Collections;

public class Test01 : MonoBehaviour {
	
	public GUIStyle sty_part1;
	
	Rect win_rect1 = new Rect(300f, 300f, 400f, 300f);
	
	// Use this for initialization
	void Start () {
		sty_part1.normal.background = (Texture2D)Resources.Load("Yellow");
	}
	
	void OnGUI (){
		win_rect1 = GUI.Window(0, win_rect1, TestWindow1, "1st Window");
	}
	
	void TestWindow1 (int WindowID)
	{
		GUI.Label(new Rect(10f, 30f, 50f , 30f), "", sty_part1);
		GUI.DragWindow();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
