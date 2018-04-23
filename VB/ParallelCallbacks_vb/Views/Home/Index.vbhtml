@Code
    ViewData("Title") = "Index"
End Code


@Html.DevExpress().Button( _
    Sub(settings)
            settings.Name = "btnStart"
            settings.Text = "Start"
            settings.UseSubmitBehavior = False
            settings.ClientSideEvents.Click = String.Format("function(s, e) {{ OnButtonClick(s, e, '{0}', '{1}'); }}", Url.Action("Start", "Home", Nothing), Url.Action("Progress", "Home", Nothing))
    End Sub
).GetHtml()
@Html.DevExpress().ProgressBar( _
    Sub(settings)
            settings.Name = "myProgressBar"
            settings.Width = System.Web.UI.WebControls.Unit.Pixel(200)
            settings.ClientVisible = False
    End Sub
).GetHtml()
