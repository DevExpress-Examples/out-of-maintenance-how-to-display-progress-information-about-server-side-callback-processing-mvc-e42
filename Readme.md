# How to display progress information about server-side callback processing (MVC)


<p>Sometimes a server-side operation, which is initiated via a callback request, may take much time (for instance, when a lot of data is obtained and being processed on the server). This example illustrates how you can inform your users about the server-side processing progress.</p><p>Note that this approach does not work if the Session state is used. It blocks parallel execution and forces parallel requests to be executed one after another because the access to ASP.NET Session state is exclusive per session. </p><p>Refer to the <a href="https://www.devexpress.com/Support/Center/p/KA18599">KA18599: How to perform parallel callbacks to get some information about server-side process</a> KB Article for explanation.</p><p><strong>See also:<br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E918">How to display progress information about server-side callback processing</a><br />
<a href="http://api.jquery.com/jQuery.ajax/"><u>jQuery.ajax()</u></a></p>

<br/>


