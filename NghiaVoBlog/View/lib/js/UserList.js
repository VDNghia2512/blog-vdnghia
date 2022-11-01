$(document).ready(function () {

    $.ajax({
        url: 'http://localhost:5114/api/user',
        type: 'GET',
        headers: {
            'Content-Type': 'application/json'
          },
        success: function (result) {
            console.log(result);
            $('tbody').empty();
            reloadUserlist(result);
            $('#UserList').DataTable()
        }
    });
});
function reloadUserlist(result) {
    var j=0;
    //Duyệt kết quả trả về
    for (let i = 0; i < result.length; i++) {
        //Tạo thông tin dòng
            if (j % 2 == 0) { var tr = '<tr class=\"trc\">'; }
            else { { var tr = '<tr class=\"trl\">'; } };
            //Thêm thông tin cột cho dòng
            console.log(result[i]);
            var td = '<td>' + result[i].id + '</td>'
                + '<td>' + result[i].displayName + '</td>'
                + '<td>' + result[i].email + '</td> '
                + '<td>' + result[i].phone + '</td> '
                + '<td>' + result[i].dateOfBirth + '</td> '
                + '<td>' + result[i].address + '</td> '
                + '<td><button onclick="DeleteUser(\'' + result[i].id + '\')" class="btn btn-danger"></button>Xóa</td>'
                ;
            //Mở rộng nội dung dòng
            tr += td + '</tr>';
            j++;
            $('tbody').append(tr);
    }

}
function DeleteUser(id) {
  
    console.log("Xóa nè");
    $.ajax({
        url: 'http://localhost:5114/api/user?id='+id,
        method: 'DELETE',
        contentType: 'application/json',
        dataType: "json",
        success: function(result) {
            // handle success
          
            location.reload(true);
        },
        error: function(request,msg,error) {
            // handle failure
        }
        });
}