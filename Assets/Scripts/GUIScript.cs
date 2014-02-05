using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {
	Hashtable args = new Hashtable();

	// Use this for initialization
	void Start () {
		args["Return"] = "";
	}
	
	// Update is called once per frame
	void Update () {

		if("" != (string)args["Return"])
		{
			Debug.Log("Get : " + args["Return"]);
			args["Return"] = "";
		}
	}

	void OnGUI()
	{
		float fPosX = 250, fPosY = 50, fYInterval = 40;
		int nYPosCount = 0;

		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 30), "Hello Boo"))
		{
			// Unalble Directly Call
			GetComponent("HelloBoo").SendMessage("PrintHelloBoo");
			GetComponent("HelloBoo").SendMessage("PrintOnConsol", "HelloBoo");	// Send Parameter

		}
		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 30), "Call C# Component"))
		{
			GetComponent("HelloBoo").SendMessage("SendMessageToCShapComponent");
		}

		nYPosCount++;
		if (GUI.Button(new Rect(fPosX, fPosY + (fYInterval * nYPosCount), 200, 30), "return From Boo"))
		{
			GetComponent("HelloBoo").SendMessage("ReturnValue", args);	// Boo will set value...
		}
	}
}
