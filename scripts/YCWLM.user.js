// ==UserScript==
// @name         因材網學習大師
// @namespace    SwetPotatoYee
// @version      1.0
// @description  後臺繼續播放教學影片
// @author       SweetPotatoYee
// @match        https://adl.edu.tw/modules_new.php*
// @grant        none
// ==/UserScript==

(function() {
    'use strict';

    const currentUrl = window.location.href;
    if (currentUrl.startsWith("https://adl.edu.tw/modules_new.php")) {
        $(window).off('blur');
        bIsBlur = false;
    }

})();
