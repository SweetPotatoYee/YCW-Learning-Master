// ==UserScript==
// @name         因材網學習大師
// @namespace    SwetPotatoYee
// @version      1.1
// @description  後臺繼續播放教學影片
// @author       SweetPotatoYee
// @match        https://adl.edu.tw/modules_new.php*
// @grant        none
// ==/UserScript==

(function() {
    'use strict';
    function waitForJQuery() {
        if (typeof $ !== 'undefined') {
            $(window).off('blur');
            bIsBlur = false;
        } else {
          setTimeout(waitForJQuery, 100);
        }
      }
      
      waitForJQuery();

})();
