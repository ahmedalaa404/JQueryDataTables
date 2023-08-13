$(document).ready(function () {

    $('#example').dataTable({
        paging: true,
        searching: true,
        serverSide: true,
        filter: true,
        ajax:
        {
            "url": "/Customers/GetCustomers",
            "type": "POST",
            "datatype": "json"
        },
        "columnDefs": [{
            "target": [0],
            "visible": false,
            "searchable": false
        }],
        "columns": [
            { "data": "id", "name": "Id", "autowidth": true },
            { "data": "firstName", "name": "FirstName", "autowidth": true },
            { "data": "lastName", "name": "LastName", "autowidth": true },
            { "data": "contact", "name": "Contact", "autowidth": true },
            { "data": "email", "name": "Email", "autowidth": true },
            { "data": "dateofBirth", "name": "DateofBirth", "autowidth": true },
            { "render": function () { return '<a href="#"  class="btn btn-danger"  onclick=DeleteCustomer("'+row.id+'") >Delete</a>' }, "orderable": false },


        ]
    });


});