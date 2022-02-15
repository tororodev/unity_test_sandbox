using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace SandBox.UI.Model
{
	public class SandboxModel
	{
		public IntReactiveProperty Counter { get; private set; } = new IntReactiveProperty();

		public void Increment()
		{
			this.Counter.Value++;
		}
	}
}