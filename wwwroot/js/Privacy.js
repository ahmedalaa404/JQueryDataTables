$(document).ready(function () {

    $('#example').dataTable({
         
        ajax: {
            "url":"/customers/GetCustomers1"   ,
            "type": "POST",
            "datatype": "json",
        },
        "columnDefs": [{
            "target": [0],
            "visible": false,
            "searchable": false,
        }],
            columns: [
                { "data": "id", "name": "Id", "autowidth": true },
                { "data": "firstName", "name": "FirstName", "autowidth": true },
                { "data": "lastName", "name": "LastName", "autowidth": true },
                { "data": "contact", "name": "Contact", "autowidth": true },
                { "data": "email", "name": "Email", "autowidth": true },
        ],
         
       
    });


});










