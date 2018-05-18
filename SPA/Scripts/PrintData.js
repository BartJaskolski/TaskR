    $.ajax({
        url: "/api/Category",
        type: 'GET',
        dataType: 'json',
        data: { categoryID: 1, categoryName: " Kategoria1" },
        success: function (result) {
            $.each(result, function (index, name) {
                console.log(name.categoryName)
                $('#SearchCategory').append($('<option>',
                    {
                        value: name.categoryID,
                        text: name.categoryName
                    }))
            })
            $('#SearchCategory').append($('<option>',
            {
                value: 0,
                text: "Wszystkie Kategorie"
            }))

        }
    });
    $(function () {

    var createAC =function(){
        var $input = $(this);

        var options = {
            source: $input.attr("data-SPA-autocomplete")
        };
        
        $input.autocomplete(options);
    };

        $("input[data-SPA-autocomplete]").each(createAC);
    });