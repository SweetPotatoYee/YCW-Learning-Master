console.log("YCW Learning Assistant Started");
window.chrome.webview.postMessage("1");
// 第一部分 - 自動跳轉
(function () {
    const currentUrl = window.location.href;
    if (currentUrl === "https://sso.ntpc.edu.tw/") {
        window.location.href = "https://pts.ntpc.edu.tw/oauth/ntpc_entry_point";
    } else if (currentUrl.startsWith("https://pts.ntpc.edu.tw/#")) {
        window.location.href = "https://pts.ntpc.edu.tw/private/service/goto/service/100/100";
    }
})();

// 第二部分 - 關閉跳離偵測
(function () {
    const currentUrl = window.location.href;
    if (currentUrl.startsWith("https://adl.edu.tw/modules_new.php")) {
        $(window).off('blur');
        bIsBlur = false;
    }
})();
