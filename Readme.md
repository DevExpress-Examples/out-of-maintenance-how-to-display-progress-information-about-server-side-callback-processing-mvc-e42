<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128566508/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4244)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/ParallelCallbacks/Controllers/HomeController.cs)
* [JSCustom.js](./CS/ParallelCallbacks/Scripts/JSCustom.js)
* [Index.cshtml](./CS/ParallelCallbacks/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to display progress information about server-side callback processing (MVC)
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4244/)**
<!-- run online end -->


<p>Sometimes a server-side operation, which is initiated via a callback request, may take much time (for instance, when a lot of data is obtained and being processed on the server). This example illustrates how you can inform your users about the server-side processing progress.</p><p>Note that this approach does not work if the Session state is used. It blocks parallel execution and forces parallel requests to be executed one after another because the access to ASP.NET Session state is exclusive per session. </p><p>Refer to the <a href="https://www.devexpress.com/Support/Center/p/KA18599">KA18599: How to perform parallel callbacks to get some information about server-side process</a> KB Article for explanation.</p><p><strong>See also:<br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E918">How to display progress information about server-side callback processing</a><br />
<a href="http://api.jquery.com/jQuery.ajax/"><u>jQuery.ajax()</u></a></p>

<br/>


