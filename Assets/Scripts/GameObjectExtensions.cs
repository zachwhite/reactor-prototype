using UnityEngine;

/// <summary>
/// Useful extensions to the base Unity GameObject.
/// </summary>
public static class GameObjectExtensions
{
	/// <summary>
	/// Check to see if a GameObject has a component that implements the specified interface.
	/// </summary>
	/// <returns><c>true</c>, if interface was implementsed, <c>false</c> if not.</returns>
	/// <typeparam name="T">The interface to be checked for.</typeparam>
	public static bool ImplementsInterface<T>(this GameObject checkGameObject)
	{
		// Get all components on gameobject
		MonoBehaviour[] monoList = checkGameObject.GetComponents<MonoBehaviour>();

		// Check if any of the components implements the target interface.
		foreach(MonoBehaviour mono in monoList)
		{
			if (mono is T)
			{
				// Gameobject implements target interface.
				return true;
			}
		}

		// Interface doesn't implement target interface.
		return false;
	}
}