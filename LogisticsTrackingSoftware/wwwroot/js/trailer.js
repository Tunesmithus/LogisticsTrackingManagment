var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Trailer/GetAll"
        },
        "columns": [
            { "data": "year", "width": "10%" },
            { "data": "make", "width": "10%" },
            { "data": "trailerType", "width": "10%" },
            { "data": "equipmentNumber", "width": "10%" },
            { "data": "vinNumber", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <a href="/Trailer/Edit?id=${data}" class="btn btn-primary">
                        <i class="bi bi-pencil-square"></i>
                     </a>
                    <a  href="/Trailer/Details?id=${data}" class="btn btn-info" >
                        <i class="bi bi-info-circle-fill"></i>
                    </a>
                    <a onClick=Delete('/Product/Delete/${data}') class="btn btn-danger">
                        <i class="bi bi-trash-fill"></i>
                    </a>

                    
                    `
                },
                "width": "30%"

            }
        ]
    });
}