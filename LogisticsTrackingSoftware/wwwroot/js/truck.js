var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $("#tblData").DataTable({
        "ajax": {
            "url": "/Truck/GetAll"
        },
        "columns": [
            { "data": "year", "width": "10%" },
            { "data": "make", "width": "10%" },
            { "data": "model", "width": "10%" },
            { "data": "equipmentNumber", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <a href="/Truck/Edit?id=${data}" class="btn btn-primary">
                        <i class="bi bi-pencil-square"></i>
                         Edit
                     </a>
                    <a  href="/Truck/Details?id=${data}" class="btn btn-info" >
                        <i class="bi bi-info-circle-fill"></i>
                        Details
                    </a>
                    <a onClick=Delete('/Product/Delete/${data}') class="btn btn-danger">
                        <i class="bi bi-trash-fill"></i>
                        Delete
                    </a>

                    
                    `
                },
                "width": "20%"

            }
        ]
    });
}