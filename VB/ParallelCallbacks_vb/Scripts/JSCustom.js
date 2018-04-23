var myTimer;
function OnButtonClick(s, e, startUrl, progressUrl) {
    StartActionOnServer(startUrl);
    StartTimer(progressUrl);
}
function StartActionOnServer(startUrl) {
    $.ajax({
        type: 'POST',
        url: startUrl,
        dataType: 'json'
    }).done(ProgressCallbackComplete).fail(CallbackError);
}
function ProgressCallbackComplete(data) {
    StopTimer();
    alert('Accomplished');
}
function StartTimer(progressUrl) {
    btnStart.SetEnabled(false);
    myProgressBar.SetVisible(true);
    myTimer = setInterval(function () {
        $.ajax({
            type: 'POST',
            url: progressUrl,
            dataType: 'json'
        }).done(TimerCallbackComplete).fail(CallbackError);
    }, 1000);
}
function StopTimer() {
    myProgressBar.SetVisible(false);
    myProgressBar.SetPosition(0);
    btnStart.SetEnabled(true);
    if (myTimer) {
        clearInterval(myTimer);
        myTimer = null;
    }
}
function TimerCallbackComplete(data) {
    myProgressBar.SetPosition(parseInt(data.ProgressResult));
}
function CallbackError() {
    StopTimer();
    alert('Callback error');
}