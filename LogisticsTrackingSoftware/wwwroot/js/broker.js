var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $("#tblData").DataTable({
        "ajax": {
            "url": "/Broker/GetAll"
        },
        "columns": [
            { "data": "companyName", "width": "10%" },
            { "data": "city", "width": "10%" },
            { "data": "state", "width": "10%" },
            { "data": "zipCode", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <a href="/Broker/Edit?id=${data}" class="btn btn-primary">
                        <i class="bi bi-pencil-square"></i>
                         
                     </a>
                    <a onClick=Delete("/Broker/Delete/${data}") class="btn btn-danger">
                        <i class="bi bi-trash-fill"></i>
                        
                    </a>
                    `
                },
                "width": "5%"

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