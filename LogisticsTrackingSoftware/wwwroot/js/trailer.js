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
            { "data": "year", "width": "5%" },
            { "data": "make", "width": "5%" },
            { "data": "trailerType", "width": "5%" },
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
                "width": "10%"

            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}