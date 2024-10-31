// 第一部分 - 自動跳轉
(function () {
    const currentUrl = window.location.href;

    if (currentUrl === "https://sso.ntpc.edu.tw/") {
            window.location.href = "https://pts.ntpc.edu.tw/oauth/ntpc_entry_point";
    } else if (currentUrl.startsWith("https://pts.ntpc.edu.tw/#")) {
            window.location.href = "https://pts.ntpc.edu.tw/private/service/goto/service/100/100";
    }
})();

// 第二部分 - alwaysOnFocus
(function () {
    const currentUrl = window.location.href;
    if (currentUrl.startsWith("https://adl.edu.tw/modules_new.php")) {
        const focusListeners = [];
        const focusListener = function (event) {
            console.log('Element focused:', event.target);
        };
        document.querySelector('input').addEventListener('focus', focusListener);
        focusListeners.push(focusListener);
        focusListeners.forEach(listener => {
            document.querySelector('input').removeEventListener('focus', listener);
        });
    }
})();
