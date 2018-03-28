using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreetingPlugin : MonoBehaviour {
	Text pluginMessage;

	// Use this for initialization
	void Start () {
		pluginMessage = GameObject.Find("PluginMessage").GetComponent<Text>();
		pluginMessage.text = "";

		// Unity -> Native Plugin
		// AndroidJavaObject(string ClassNameWithPakcage)
		AndroidJavaObject pluginObject = new AndroidJavaObject("youten.redo.unity.androidplugin.HelloPlugin");
		// CallStatic<return value type>(string methodName, string[] params)
		string greeting = pluginObject.CallStatic<string>("createGreeting", gameObject.name, "Unity");
		pluginMessage.text += greeting;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onHello(string message) {
		// Native Plugin -> Unity
		pluginMessage.text += "\n" + message;
	}
}
