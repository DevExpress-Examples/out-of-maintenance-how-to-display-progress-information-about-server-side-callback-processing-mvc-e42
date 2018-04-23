Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.SessionState

Namespace DevExpressMvcApplication1.Controllers
	Public Class HomeController
		Inherits Controller
        Private Shared _progress As Integer
		Public Function Index() As ActionResult
			Return View()
		End Function
		<HttpPost> _
		Public Function Start() As JsonResult
			Dim count As Integer = 10
			For i As Integer = 0 To count - 1
                _progress = Convert.ToInt32(Convert.ToDouble(i) / Convert.ToDouble(count) * 100)
				System.Threading.Thread.Sleep(500)
			Next i
			Dim result = New With {Key .StartResult = "ok"}
            _progress = 0
			Return Json(result)
		End Function
		<HttpPost> _
		Public Function Progress() As JsonResult
            Dim result = New With {Key .ProgressResult = _progress}
			Return Json(result)
		End Function
	End Class
End Namespace
