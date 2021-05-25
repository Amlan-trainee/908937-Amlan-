$(document).ready(function()
{
    $('#btnAdd').on('click',function(){
        console.log("Hello");
        var a=$("#firstnum");
        var b=$("#lastnum");
        if(a.val()=='' || b.val()=='')
        {
            $('div').html("<div style='color:red;'> please, Enter the values </div>");
        }
        else{
            var ans = parseInt(a.val()) + parseInt(b.val());
            $('div').html("<div style='color:green;'></div>").val(ans);
            $('#answer').val(ans);
        }
    });
});