var Account = Account || {};

Account.delete = function (Id) {
    bootbox.confirm({
        title: "Cảnh báo",
        message: "Bạn có chắc chắn xóa không?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> No'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Yes'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `/Account/Delete/${Id}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data.deleteResult) {
                            window.location.href = "/Account/Index/";
                        }
                        else {
                            bootbox.alert("Invalid Id User");
                        }
                    }
                });
            }
        }
    });
};
