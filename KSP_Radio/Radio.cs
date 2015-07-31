using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace KSP_Radio
{
	[KSPAddon(KSPAddon.Startup.SpaceCentre, false)]
	public class Radio : MonoBehaviour
	{

		private static Rect winPosition = new Rect (0, 0, 320, 240);
		private static GUIStyle winStyle = null;
		private static Boolean btnState = false;

		public void Awake() {
			RenderingManager.AddToPostDrawQueue (0, OnDrawInterface);
		}

		private void OnDrawInterface() {
			// init window 
			winPosition = GUI.Window (
				1337, 
				winPosition, 
				_initWindow, 
				"KSP Radio", 
				winStyle
			);
		}

		private void _initWindow(int windowId) {
			GUILayout.BeginHorizontal();
			GUILayout.Label ("ABC-");
			GUILayout.Label ("123");
			GUILayout.EndHorizontal();

			GUILayout.BeginHorizontal();
			btnState = GUILayout.Toggle (btnState, "Button state: " + btnState);

			GUI.DragWindow();
		}

		/**
		 * Method is called upon the first
		 * 
		 * @return void
		 */ 
		protected void Start() {

			Logger.Log ("KSP Radio initialized.");

			// init window style
			winStyle = new GUIStyle (HighLogic.Skin.window);

		}
	}
}

