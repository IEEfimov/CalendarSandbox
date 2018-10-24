var isVisible = false;
var form;
var items;
var wrapper;


function dropDownType(btn) {
    form = document.getElementById("dropDown");
    wrapper = document.getElementById("wrapper");
    items = document.getElementsByClassName("dropItem");

    var rect = btn.getBoundingClientRect();

    form.style.top = rect.bottom + "px";
    form.style.left = rect.left + "px";

    if (isVisible) hideDD();
    else showDD();
}
function hideDD() {
    if (isVisible == false) return;
    isVisible = false;

    wrapper.style.visibility = "hidden";
    wrapper.style.opacity = "0.5";

    form.style.display = "none";

    form.style.height = '0px';
    form.style.width = '0px';


    for (i = 0; i < items.length; i++) {
        items[i].style.visibility = "hidden";
    }
}
function showDD() {
    if (isVisible) return;
    wrapper.style.visibility = "visible";
    wrapper.style.opacity = "0";

    form.style.display = "flex";
    isVisible = true;

    form.style.height = '0px';
    form.style.width = '0px';

    var animation = form.animate([
        { height: '0px', width: '0px' },
        { height: '100px', width: '170px' }
    ], 70);
    animation.addEventListener('finish', function () {
        form.style.height = '100px';
        form.style.width = '170px';
        for (i = 0; i < items.length; i++) {
            items[i].style.visibility = "visible";
        }
    });

    
}

function EditEventForm() {
    form = document.getElementById("dropDown");
    wrapper = document.getElementById("wrapper");
    items = document.getElementsByClassName("dropItem");

    var pageHeight = document.documentElement.clientHeight;
    var pageWidth = document.documentElement.clientWidth;

    form.style.top = "100px";
    form.style.left = pageWidth / 4 + "px";
    form.style.width = pageWidth / 2 + "px";
    form.style.height = pageHeight / 1.2 + "px";

    if (isVisible) hideEE();
    else showEE();
}

function hideEE() {
    if (isVisible == false) return;
    isVisible = false;

    wrapper.style.visibility = "hidden";
    wrapper.style.opacity = "0.5";

    form.style.width = "0px";
    form.style.height = "0px";

    from.style.transform = "scale(0.6)";


    form.style.display = "none";

}
function showEE() {
    if (isVisible) return;
    isVisible = true;

    wrapper.style.visibility = "visible";
    wrapper.style.opacity = "0.5";

    var animation = form.animate([
        { transform: 'scale(0.6)'},
        { transform: 'scale(1)'}
    ], 100);
    animation.addEventListener('finish', function () {
        form.style.transform = "scale(1)";
    });

    form.style.display = "flex";
    

}


function cellMouseOn(i) {
    //var calendar = document.getElementById("calendar");
    //calendar.style
}