using System;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace SandBox.UI.Presenter
{
	public class SandboxPresenter : UIPresenter, IDisposable
	{
		private CompositeDisposable disposables = new CompositeDisposable();
		private readonly View.SandboxView view;
		private readonly Model.SandboxModel model;

		public View.SandboxView View { get { return this.view; } }

		public SandboxPresenter(Model.SandboxModel model, View.SandboxView view)
		{
			this.model = model;
			this.view = view;

			this.model.Counter.Subscribe(this.view.SetCounter);
			this.view.IncrementEvent.Subscribe(_ => this.model.Increment());
		}

		public void Dispose()
		{
			this.disposables.Clear();
		}
	}
}