function click1(count)
{
    alert("paspausta");
    for (var i = 0; i < count; i++)
    {
        alert("paspausta " + i);
    }
    
}

function hideShow() {
    var left_elem = document.getElementById("left");
    if (left_elem.style.display != "none") {
        left_elem.style.display = "none";
    }
    else {
        left_elem.style.display = "inline-block";
    }
}