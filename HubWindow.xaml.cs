using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

using Windows.Foundation;
using Windows.Foundation.Collections;

namespace ToolHub;

/// <summary>
/// The main window of the tool hub.
/// </summary>
public sealed partial class HubWindow : Window {
	public HubWindow() {
		this.InitializeComponent();
	}

	private void myButton_Click( object sender, RoutedEventArgs e ) {
		myButton.Content = "Clicked";
	}
}
