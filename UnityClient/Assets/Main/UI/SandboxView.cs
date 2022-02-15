using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

namespace SandBox.UI.View
{
	public class SandboxView : UIView
	{
		[SerializeField] private Text counterText = null;
		[SerializeField] private Button incrementButton = null;

		public IObservable<Unit> IncrementEvent => this.incrementButton.OnClickAsObservable();

		public void SetCounter(int counter)
		{
			this.counterText.text = $"count: {counter}";
		}
	}
}