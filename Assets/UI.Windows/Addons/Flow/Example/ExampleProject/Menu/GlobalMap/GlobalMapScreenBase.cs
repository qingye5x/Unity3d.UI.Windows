//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the UI.Windows Flow Addon.
//     You may simply edit this file to setup your behavior.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI.Windows;
using UnityEngine.UI.Windows.Types;

namespace ExampleProject.UI.Menu.GlobalMap {

	public class GlobalMapScreenBase : LayoutWindowType {
		
		/// <summary>
		/// Flows to the GameTypeChooser.
		/// Full Name: ExampleProject.UI.Menu.GameTypeChooser.GameTypeChooserScreen
		/// </summary>
		/// <returns>GameTypeChooser</returns>
		public virtual ExampleProject.UI.Menu.GameTypeChooser.GameTypeChooserScreen FlowGameTypeChooser(params object[] parameters) {
			
			return WindowSystem.Show<ExampleProject.UI.Menu.GameTypeChooser.GameTypeChooserScreen>(parameters);
			
		}
				
		/// <summary>
		/// Flows to the Shop.
		/// Full Name: ExampleProject.UI.Menu.ShopOperations.Shop.ShopScreen
		/// </summary>
		/// <returns>Shop</returns>
		public virtual ExampleProject.UI.Menu.ShopOperations.Shop.ShopScreen FlowShop(params object[] parameters) {
			
			return WindowSystem.Show<ExampleProject.UI.Menu.ShopOperations.Shop.ShopScreen>(parameters);
			
		}
		
	}

}