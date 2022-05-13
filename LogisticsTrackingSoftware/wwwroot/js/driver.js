var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Drivers/GetAll"
        },
        "columns": [
            { "data": "firstName", "width": "10%" },
            { "data": "lastName", "width": "10%" },
            { "data": "email", "width": "10%" },
            { "data": "phoneNumber", "width": "10%" },
            { "data": "driverPay", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <a href="/Drivers/Edit?id=${data}" class="btn btn-primary">
                        <i class="bi bi-pencil-square"></i>
                         Edit
                     </a>
                    <a  href="/Drivers/Details?id=${data}" class="btn btn-info" >
                        <i class="bi bi-info-circle-fill"></i>
                        Details
                    </a>
                    <a onClick=Delete('/Product/Delete/${data}') class="btn btn-danger">
                        <i class="bi bi-trash-fill"></i>
                        Delete
                    </a>

                    
                    `
                },
                "width": "30%"

            }
        ]
    });
}