Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace BarManagerControllerExample
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnExit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Wpf.Bars.ItemClickEventArgs)
			Close()
		End Sub

		Private Sub btnAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Wpf.Bars.ItemClickEventArgs)
			MessageBox.Show("About Window")
		End Sub

		Private Sub myButton_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Wpf.Bars.ItemClickEventArgs)

		End Sub

		Private Sub myButton2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Wpf.Bars.ItemClickEventArgs)

		End Sub
	End Class
End Namespace
