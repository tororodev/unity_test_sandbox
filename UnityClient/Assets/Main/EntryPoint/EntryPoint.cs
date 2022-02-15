using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SandBox
{
	public class EntryPoint : MonoBehaviour
	{
		protected void Start()
		{
			var canvas = GameObject.Instantiate(Resources.Load<GameObject>("Canvas"));
			var model = new UI.Model.SandboxModel();
			var sandbox = UI.UIFactory.CreateSandbox("SandboxUI", model, canvas.transform);
		}
	}
}