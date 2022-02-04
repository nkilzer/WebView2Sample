This repository is a sample for the WebView2 control to illustrate the issue with an auto-printing popup.

To execute the sample, set up a static web server for the "docs" subdirectory, and then use the textbox to set the path and press "GO".

Documents:

This was the original test case - a self-printing modal popup that only printed some data in the page
--------------------------
TestDocFail.html - produces a popup that causes a crash in a MoveFocus handler, and aborts the process
TestDocCrash.html - produces a popup that causes a crash in a MoveFocus handler, and aborts the process (this popup does not have the window.close() call)
TestDocNoPrint.html - produces a popup that does not crash, but does not automatically print
TestDocNoPrintClose.html - produces a popup that does not crash, but does not automatically print, and requests close immediately

This is the rendered content of the popup - as if it was loaded directly
------------------------------------------
RenderedDocFail.html - Des not auto print, and does not request close (doesn't crash directly though, or trigger ProcessFailed)
RenderedDocNoTitle.html - Does auto print, but requests close immediately before the dialog is terminated (doesn't crash)
RenderedDocTitleOK.html - Does auto print, doesn't request close, but does include the {title} element (which seems to be necessary to trigger the crash)
RenderedDocOK.html - Does not request closure, but does auto print