using UnityEngine;
using System.Collections;

public class Test01 : MonoBehaviour {
	
	public GUIStyle sty_part1;
	
	Rect win_rect1 = new Rect(300f, 300f, 400f, 300f);
	
	// Use this for initialization
	void Start () {
	
	}
	
	void OnGUI (){
		win_rect1 = GUI.Window(0, win_rect1, TestWindow1, "1st Window");
	}
	
	void TestWindow1 (int WindowID)
	{
		
		GUI.DragWindow();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
