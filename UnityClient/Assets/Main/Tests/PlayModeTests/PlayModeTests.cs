using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;

public class PlayModeTests
{
	[Test]
	public void SandboxUI_Test()
	{
		var canvas = GameObject.Instantiate(Resources.Load<GameObject>("Canvas"));

		// ex: MVRPのテスト
		var model = new SandBox.UI.Model.SandboxModel();
		var presenter = SandBox.UI.UIFactory.CreateSandbox("SandboxUI", model, canvas.transform);

		var counterText = Utils.TestUtils.GetPrivateField<Text>(presenter.View, "counterText");
		var incrementButton = Utils.TestUtils.GetPrivateField<Button>(presenter.View, "incrementButton");

		// V -> P -> M -> V
		Assert.AreEqual(counterText.text, $"count: 0");
		Assert.AreEqual(model.Counter.Value, 0);
		incrementButton.onClick.Invoke();
		Assert.AreEqual(counterText.text, $"count: 1");
		Assert.AreEqual(model.Counter.Value, 1);
		incrementButton.onClick.Invoke();
		Assert.AreEqual(counterText.text, $"count: 2");
		Assert.AreEqual(model.Counter.Value, 2);
	}
}

