function click1(count)
{
    alert("paspausta");
    for (var i = 0; i < count; i++)
    {
        alert("paspausta " + i);
    }
    
}

var isHidden = false;

function hideShow() {
    if (isHidden)
    {
        isHidden = false;
        $("#left").show(1000);        
    }
    else
    {
        isHidden = true;
        $("#left").hide(1000);
    }
}