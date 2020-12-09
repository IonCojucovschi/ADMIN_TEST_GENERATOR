// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.




$('.image-file-upload').change(function (evt) {
    //$('#Image1').hide();
    //debugger;
    let setIMageForClass = evt.target.id;
    if (setIMageForClass) {
        $("." + setIMageForClass).hide();
        var reader = new FileReader();
        reader.onload = function (e) {
            $("." + setIMageForClass).show();
            $("." + setIMageForClass).attr("src", e.target.result);
        }
        reader.readAsDataURL($(this)[0].files[0]);
    }
});

