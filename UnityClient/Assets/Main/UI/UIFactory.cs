using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace SandBox.UI
{
	public static class UIFactory
	{
		private static T CreateView<T>(string prefabPath, Transform parent) where T : UI.View.UIView
		{
			var res = Resources.Load<GameObject>(prefabPath);
			var go = GameObject.Instantiate(res, parent);
			var view = go.GetComponent<T>();
			return view;
		}

		public static UI.Presenter.SandboxPresenter CreateSandbox(string prefabPath, UI.Model.SandboxModel model, Transform parent)
		{
			var view = CreateView<UI.View.SandboxView>(prefabPath, parent);
			var presenter = new UI.Presenter.SandboxPresenter(model, view);
			return presenter;
		}
	}
}