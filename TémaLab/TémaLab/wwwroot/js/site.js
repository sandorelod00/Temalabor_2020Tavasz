// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


/*Side Bar*/
/* Set the width of the sidebar to 250px (show it) */
function openNav() {
    document.getElementById("mySidepanel").style.width = "250px";
}

/* Set the width of the sidebar to 0 (hide it) */
function closeNav() {
    document.getElementById("mySidepanel").style.width = "0";
}



function unhideMyProflieElements() {
    documnet.getElementById("IntroductionLink").style.visibility = "visible";
    document.getElementById("FriendsLink").style.visibility = "visible";
    document.getElementById("EditProfileLink").style.visibility = "visible";
}