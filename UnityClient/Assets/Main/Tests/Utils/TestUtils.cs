using System.Reflection;

public class Utils
{
	public static class TestUtils
	{
		public static T GetPrivateField<T>(object obj, string fieldName) where T : class
		{
			var f = obj.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
			if (f == null)
			{
				throw new System.Exception($"Field is not found: {fieldName} ({typeof(T)})");
			}
			var field = f.GetValue(obj) as T;
			return field;
		}
	}
}
