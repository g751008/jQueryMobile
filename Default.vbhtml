﻿@Code
    '@Code是插入伺服端程式碼的區塊
End Code
<!DOCTYPE html>
<html lang="en">
    <!--下方是標準HTML5網頁架構-->
    <head>
        <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1" /><!--Mobile網頁需要額外使用Meta標籤Viewport來告訴瀏覽器所看到的網頁尺寸，否則瀏覽器會以為在瀏覽桌上型電腦網頁，最早出現於Safari-->
        <!--
            在content屬性提供參數定義進一步尺寸和縮放資訊:
            width指定瀏覽器顯示的寬度，device-width是行動裝置的螢幕寬度，也可以指定數值的絕對寬度。
            height指定瀏覽器顯示的高度，device-height是行動裝置的螢幕高度，也可以指定數值的絕對高度。
            initial-scale屬性指定畫面用多少倍viewport來顯示，1就是指1個viewport等於1個螢幕像素。
            user-scalable指定是否允許使用者調整螢幕縮放。
            minimum-scale指定可以使用的最小縮放(0~10)。
            maximum-scale指定可以使用的最大縮放(0~10)。
            target-densityDpi是Android內建瀏覽器支援的額外參數，告訴行動裝置此網頁設計的dpi(Dots per Inch每英吋像數)，值device-dpi(符合行動裝置螢幕的dpi)、high-dpi(高dpi)、medium-dpi(中dpi)、low-dpi(低dpi)或指定40~700。
        -->        
        <title></title>
    </head>
    <body>
    jQuery Mobile是基於jQuery函數庫和jQuery UI建立的手機平台框架，2010年推出初版，2011年推出正式版，由jQuery專案小組開發，提供輕量化程式碼和樣式，一套使用介面系統，不用寫JavaScript程式碼，單純使用HTML標籤就能建立行動裝置網站的使用介面。
        <br />
    jQuery Mobile程式檔案是一份內嵌一些外部檔案(jQuery函數庫的JavaScript程式檔、jQuery Mobile核心JavaScript程式檔、jQuery Mobile核心CSS外部樣式檔、jQuery Mobile佈景的外部樣式檔(有自訂佈景才需要))的HTML5網頁文件，所以是一組檔案的集合。
        <br />
    jQyery Mobile提供AJAX的技術的巡覽系統可以建立動畫效果的頁面轉換，使用卡片觀念來建立頁面結構(基本單位)可減少延遲和下載時間，盒子是HTML網頁文件，每張卡片是一個扮演page角色的div標籤，如同一盒卡片。頁面之間可透過a超連結互相連結。一個jQuery Mobile檔案可建立一個頁面或多頁面，也可以多檔案多頁面。顯示頁面時會隱藏上方URL位址欄位，是為了建立更像原生應用程式的使用介面。
        <br />
    WML語言(Wireless Markup Language)就可以一個檔案建立多個虛擬頁面，每個虛擬頁面稱為卡片(Cards)，WML文件稱為一副紙牌(Deck)。
        <br />
    到官網"Zip File: jquery.mobile.zip (JavaScript, CSS, and images)"連結下載，demos目錄是範例程式，而必要檔案為images目錄(jQuery Mobile使用的圖示檔)、jQuery.mobile.min.css(jQuery Mobile的CSS樣式檔案)、jquery.mobile.min.js(jQuery Mobile的外部JavaScript程式檔案)
    ，檔案結尾的min表示壓縮過的檔案(刪除空白字元和換行後的最小尺寸)，min版本為實際執行時使用，需要除錯則用沒有min字尾的版本，可將檔名版號刪除方便以後升級jQuery Mobile。另外需再下載jQuery加入網站就完成安裝。
        <br />
    在HTML網頁要使用jQuery Mobile可以使用script和link標籤引用外部檔案，或是使用CDN(將資料放在網路系統的全球多個伺服器，從最近的伺服器取得資料)。範例如下:
        < link rel="stylesheet" href="http://code.jquery.com/mobile/1.1.1/jquery.mobile-1.1.1.min.css" />
        < script src="http://code.jquery.com/mobile/1.1.1/jquery.mobile-1.1.1.min.js"></ script>
        < script src="http://code.jquery.com/jquery-1.7.1.min.js"></ script>
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
        <br />
        WebMatrix可安裝iPhone Simulator Lite版本:執行-新增...-進入瀏覽器擴充組件庫頁面安裝，執行-iPhone開啟，在iPhone畫面的右鍵視窗按File-Exit指令結束iPhone Simulator。Lite版本功能不齊全可安裝Opera Mobile Emulator功能更完整，jQuery Mobile最佳解析度是480x640(VGA Portrait)。
        <br><br>
    Visual Studio是微軟的整合開發環境，能在同一套應用程式編輯、編譯、偵錯、測試.NET語言應用程式，Express版是Visual Studio產品線的擴充，提供免費實用且最少負擔的開發工具。
    </body>
</html>
