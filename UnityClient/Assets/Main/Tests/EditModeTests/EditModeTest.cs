using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;
using UniRx;

public class EditModeTest
{
	[Test]
	public void SandboxModel_Test()
	{
		// ex: Modelの単体テスト
		var model = new SandBox.UI.Model.SandboxModel();
		Assert.AreEqual(model.Counter.Value, 0);
		model.Increment();
		Assert.AreEqual(model.Counter.Value, 1);
		model.Increment();
		Assert.AreEqual(model.Counter.Value, 2);
	}
}
