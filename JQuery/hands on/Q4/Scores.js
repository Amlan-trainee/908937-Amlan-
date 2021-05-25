$(document).ready(function()
{
    $(".txt").each(function() 
    {
        $(this).keyup(function()
        {
            calculateSum();
        });
    });

});

function calculateSum() 
{
    var tot = 0;
    $(".txt").each(function() 
    {
        if(!isNaN(this.value) && this.value.length!=0) 
        {
            tot=tot+parseFloat(this.value);
        }
    });
    $("#sum").html(tot.toFixed(2));
}