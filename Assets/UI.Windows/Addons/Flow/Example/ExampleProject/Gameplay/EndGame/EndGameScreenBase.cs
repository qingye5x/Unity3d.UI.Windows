//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the UI.Windows Flow Addon.
//     You may simply edit this file to setup your behavior.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI.Windows;
using UnityEngine.UI.Windows.Types;

namespace ExampleProject.UI.Gameplay.EndGame {

	public class EndGameScreenBase : LayoutWindowType {
		
		/// <summary>
		/// Flows to the MenuLoader.
		/// Full Name: ExampleProject.UI.Other.MenuLoader.MenuLoaderScreen
		/// </summary>
		/// <returns>MenuLoader</returns>
		public virtual ExampleProject.UI.Other.MenuLoader.MenuLoaderScreen FlowMenuLoader(params object[] parameters) {
			
			return WindowSystem.Show<ExampleProject.UI.Other.MenuLoader.MenuLoaderScreen>(parameters);
			
		}
		
	}

}