@Code
    '@Code是插入伺服端程式碼的區塊
End Code
<!DOCTYPE html>
<html lang="en">
    <!--下方是標準HTML5網頁架構-->
    <head>
        <meta charset="utf-8" />
        <title></title>
    </head>
    <body>
    jQuery Mobile是基於jQuery函數庫建立的手機平台框架，2011年推出正式版，由jQuery專案小組開發，一套使用介面系統，不用寫JavaScript程式碼，單純使用HTML標籤就能建立行動裝置網站的使用介面。
        <br />
        <br />
    ASP.NET有三種開發模型：
        <br />
    ASP.NET Web Forms開發模型是傳統的事件驅動和伺服端控制項ASP.NET開發模型，目的是隱藏HTTP請求，以如同建立Windows應用程式一般的建立Web應用程式，但伺服端控制項全權處理頁面的顯示，搭配客戶端網頁技術會有很多限制。
        <br />
    ASP.NET Web Pages開發模型是一種以頁面為中心的開發模型，類似ASP和PHP技術，可以讓開發者全權控制網頁的顯示和整合客戶端網頁技術，使用內建範本和幫助者類別來快速建立Web應用程式，使用Razor語法。
        <br />
    ASP.NET MVC開發模型使用著名的MVC設計模式來建立Web應用程式，將Web應用程式分割為Models(資料)、Views(顯示)、Controllers(處理請求)，顯示部分預設使用Razor語法。
        <br />
        <br />
    建立跨行動裝置網站的方法：可從伺服端偵測行動裝置的平台和瀏覽器直接回傳正確格式的頁面，或在客戶端使用CSS(Media Queries)，依據不同螢幕尺寸套用不同的CSS樣式。
        <br />
    ASP.NET舊版Mobile Web的開發建立的Web控制項是輸出成WAP而非HTML5已經不符合市場潮流。而ASP.NET4.5全面擁抱Open Source的當紅網頁技術(例如jQuery函數庫和jQuery Mobile框架)。
        <br />
    ASP.NET Web Forms開發模型以伺服端控制項來處理頁面顯示，對客戶端jQuery Mobile元件的支援不完整，只有部分控制項可加上data-role屬性轉換成jQuery Mobile元件(如ListView、DataList、Repeater)，ListBox和DataGrid等控制項相容性不佳，ViewState不建議使用在Mobile網站(會造成檔案尺寸肥大)，如果整合jQuery Mobile框架建議使用AMF(ASP.NET Mobile Framework，基於jQuery Mobile建立的伺服端控制項)。
        <br />
    ASP.NET Web Pages開發模型使用和MVC相同Razor引擎，可全權處理網頁顯示來整合jQuery Mobile框架，對中小型的跨行動裝置網站是最佳選擇。
        <br />
    ASP.NET MVC開發模型自MVC3開始Views的預設檢視引擎改為Razor引擎，可全權處理網頁顯示，完全整合jQuery Mobile框架，ASP.NET4.5的Mobile支援大部分是針對MVC而不是Web Forms。
        <br />
        <br />
    Web開發方式有兩種:
        <br />
    Web應用程式(Web Application)透過HTTP請求來存取Web伺服器的網頁或執行伺服端網頁技術的程式碼，ASP.NET、PHP、JSP等，簡單來說就是一組網頁的集合。
        <br />
    Web服務(Web Services)透過SOAP(Simple Object Access Protocol(傳統，結合XML和HTTP))通訊協定或RESTful API(REpresentational State Transfer(取代SOAP，使用XML或JSON等簡單介面，一種分散式軟體系統架構樣式))提供資料交換和工作分享，也是使用HTTP進行通訊，簡單來說就是提供一組通用的遠端函數呼叫(RPC，Remote Procedure Calls)，讓客戶端使用函數呼叫來執行服務。
        <br />
    REST最主要的觀念是資源(Resources)，即一種特殊資訊，使用HTTP的URI(網址)來識別這些資源以便客戶端請求來進行處理，回傳的資源格式是HTML、XML或JSON。
        <br />
    RESTful Web服務屬於輕量級，客戶端通常使用AJAX技術送出HTTP請求，以HTTP預設的POST、GET、PUT、DELETE等動作方法識別所需資源，伺服端通常回應XML或JSON，客戶端再用JavaScript或jQuery處理取得資源。
        <br />
    https://www.programmableweb.com/apis/directory 可查詢指定網站提供的API。
        <br />
        <br />
    Mobile應用程式(Mobile Apps)有兩種:
        <br />
    原生應用程式(Native Apps)使用各平台專屬的開發工具和程式語言來開發。
        <br />
    Mobile Web應用程式，如同桌上電腦的Web應用程式，程式儲存在Web伺服器。只出現傳統Web應用程式的核心功能，設計時要注意螢幕尺寸、輸入方式、最新標準規格相容性、頻寬(檔案尺寸)，這些問題可丟給jQuery Mobile框架來處理。
        <br />
        <br />
    WebMatrix是微軟開發的免費輕量的Web整合開發工具，支援ASP.NET技術也支援其他伺服端網頁技術(例如:PHP)，組成元件如下:
        <br />
    IIS Express:簡易版IIS的Web伺服器(可供開發網站測試部署)、ASP.NET:ASP.NET伺服端網頁技術(WebMatrix支援的是ASP.NET Web Pages開發模型)、SQL Server Compact:SQL Server資料庫系統的內嵌式版本、行動瀏覽器模擬器:提供iPhone和Windows Phone行動瀏覽器的模擬器。
        <br />
    WebMatrix使用介面由上而下分別是快速存取工具列和Ribbon介面、站台窗格、工作區選擇器，選擇工作區後站台窗格會顯示相關資訊，右邊是內容窗格，使用標籤頁顯示和編輯網頁內容，.vbhtml是Web Pages開發模型使用VB語言的副檔名，C#則是.cshtml。
        <br />
    更改預設站台的方法:檔案-選項-左邊選"站台"-更改"預設站台位置"。
        <br>
        WebMatrix執行站台會進入站台首頁，要瀏覽指定網頁，在檔案工作區，檔案上按右鍵選單選擇"在瀏覽器啟動"。
        <br><br>
        Visual Studio是微軟的整合開發環境，能在同一套應用程式編輯、編譯、偵錯、測試.NET語言應用程式，Express版是Visual Studio產品線的擴充，提供免費實用且最少負擔的開發工具。
    </body>
</html>
