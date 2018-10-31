function init() {
    var header = document.getElementById("header");
    var calendar = document.getElementById("calendar");
    var sideBar = document.getElementById("sideBar");
    var typeSelector = document.getElementById("typeSelector");
    var currentData = document.getElementsByClassName("currentDate")[0];
    var microCalendarWrap = document.getElementById("microCalendar");

    var wrapper = document.getElementById("wrapper");

    var pageHeight = document.documentElement.clientHeight;
    var pageWidth = document.documentElement.clientWidth;

    wrapper.style.width = pageWidth + "px";
    wrapper.style.height = pageHeight + "px";

    typeSelector.style.marginLeft = (pageWidth - currentData.offsetWidth - 725) + "px";
    var calendarWidth = calendar.offsetWidth;

    var items = document.getElementsByClassName("item");
    for (i = 0; i < items.length; i++) {
        items[i].style.width = (Math.floor(calendarWidth / 7)) + "px";
        items[i].style.height = ((pageHeight - 60) / 5) + "px";
    }

    calendar.style.visibility = "visible";
    sideBar.style.visibility = "visible";
    header.style.visibility = "visible";
}