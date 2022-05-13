var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $("#tblData").DataTable({
        "ajax": {
            "url": "/Dispatcher/GetAll"
        },
        "columns": [
            { "data": "name", "width": "40%" },
            { "data": "dispatchFee", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <a href="/Dispatcher/Edit?id=${data}" class="btn btn-primary">
                        <i class="bi bi-pencil-square"></i>
                         
                     </a>
                    <a onClick=Delete("/Dispatcher/Delete/${data}") class="btn btn-danger">
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