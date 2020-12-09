


$('#createResponseItem').click(function () {

    var model = '<div><input style="width:400px" data-type="inputResponse" class="when-input-ischanged" type="text" value=""/><input style="margin:5px;" data-type="isTrue" type="checkbox" onchange="istrueOrFalse(this)" value="false"><div class="removeResponse" onClick="removeResponse(this)">x</div></div>';
    $('#responsesListManaged').append(model);




})

function istrueOrFalse(e) {
    if (e.value == 'true')
        e.value = 'false'
    else
        e.value = 'true'

    console.log('Event :', e);
}
function removeResponse(e) {
    e.parentElement.remove()
}


function setAllResponses()
{
    $("#responsesList").empty();
    $('#responsesListManaged').children().each((index, item) => {
        
        $(item).children().each((ind, elm) => {
            if (elm.getAttribute('data-type')) {
                let tempValue = elm.getAttribute('data-type');
                let virtualResponse = '';
                switch (tempValue) {
                    case 'isTrue':
                        if (elm.value=="true")
                            virtualResponse = '<input  name="model.Responses[' + index + '].IsRight" value="' + elm.value + '" checked />';
                        else
                            virtualResponse = '<input  name="model.Responses[' + index + '].IsRight" value="' + elm.value + '" />';

                        $("#responsesList").append(virtualResponse)
                        break;
                    case 'inputResponse':
                        virtualResponse = '<input  name="model.Responses[' + index + '].Response" value="' + elm.value + '" checked />';
                        $("#responsesList").append(virtualResponse)
                        break;
                }
            }
        });

    });

}

///#responsesList 


