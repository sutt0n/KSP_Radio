using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace KSP_Radio
{
	public class Logger : MonoBehaviour
	{

		public enum Severity {
			Notice = 0,
			Warning = 1,
			Fatal = 2
		};

		public static void Log(string message, Severity level = Severity.Notice) {

			string severity;

			switch (level) {
			case Severity.Warning:
				severity = "[SEVERE]";
				break;
			
			default:
			case Severity.Notice:
				severity = "[NOTICE]";
				break;

			case Severity.Fatal:
				severity = "[FATAL]";
				break;
			}

			print("[KSP Radio] " + severity + ": " + message);

		}

	}
}

