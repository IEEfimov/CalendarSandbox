function init() {
    var header = document.getElementById("header");
    var calendar = document.getElementById("calendar");
    var sideBar = document.getElementById("sideBar");
    var icon = document.getElementsByClassName("icon")[0];
    var typeSelector = document.getElementById("typeSelector");
    var currentData = document.getElementsByClassName("currentDate")[0];
    var microCalendarWrap = document.getElementById("microCalendar");

    var wrapper = document.getElementById("wrapper");

    var pageHeight = document.documentElement.clientHeight;
    var pageWidth = document.documentElement.clientWidth;

    wrapper.style.width = pageWidth + "px";
    wrapper.style.height = pageHeight + "px";

    var newsideBarWidth = pageWidth / 5;
    if (newsideBarWidth > 250) newsideBarWidth = 250;
    sideBar.style.width = newsideBarWidth + "px";
    icon.style.marginRight = (newsideBarWidth - 50) + "px";
    typeSelector.style.marginLeft = (pageWidth - currentData.offsetWidth - newsideBarWidth - 475) + "px";
    calendar.width = header.offsetWidth - newsideBarWidth;
    calendar.style.width = (header.offsetWidth - newsideBarWidth) + "px";
    var calendarWidth = calendar.offsetWidth;

    var items = document.getElementsByClassName("item");
    for (i = 0; i < items.length; i++) {
        items[i].style.width = (Math.floor(calendarWidth / 7) - 2) + "px";
        items[i].style.height = ((pageHeight - 60) / 5) + "px";
    }
    calendar.style.calendarWidth = calendarWidth + "px";
    calendar.style.minHeight = (pageHeight - 60) + "px";

    console.log("" + microCalendarWrap.offsetWidth);
    var microCalendarWidth = microCalendarWrap.offsetWidth;
    microCalendarWrap.style.height = (microCalendarWidth / 7 * 5) + "px";

    calendar.style.visibility = "visible";
    sideBar.style.visibility = "visible";
    header.style.visibility = "visible";
}