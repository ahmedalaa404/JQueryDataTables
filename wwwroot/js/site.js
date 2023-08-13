$(document).ready(function () {

    $('#example').dataTable({
        paging: true,
        searching: true,
        serverSide: true,
        filter: true,
        ajax:
        {
            "url": "/customers/GetCustomers",
            "type": "POST",
            "datatype": "json",
        },
        "columnDefs": [{
            "target": [0],
            "visible": false,
            "searchable": false,
        }],
        "columns": [
            { "data": "id", "name": "Id", "autowidth": true },
            { "data": "firstName", "name": "FirstName", "autowidth": true },
            { "data": "lastName", "name": "LastName", "autowidth": true },
            { "data": "contact", "name": "Contact", "autowidth": true },
            { "data": "email", "name": "Email", "autowidth": true },
            //{ "data": "birthDate", "name": "BirthDate", "autowidth": true },
            { "data": "birthDate", "name": "BirthDate", "autowidth": true },
            { "render": function (data, type, row) { return '<a href="#"  class="btn btn-danger"  onclick=DeleteCustomer("' + row.id + '") >Delete</a>' }, "orderable": false },


        ],
    });


});










