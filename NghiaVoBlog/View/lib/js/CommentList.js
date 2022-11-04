var dataget;
$(document).ready(function () {

    $.ajax({
        url: 'http://localhost:5114/api/comment',
        type: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (result) {
            dataget = result;
            console.log(result);
            $('tbody').empty();
            reloadCommentList(result);
            $('#CommentList').DataTable();
        }
    });
});
function reloadCommentList(result) {
    var j = 0;
    //Duyệt kết quả trả về
    for (let i = 0; i < result.length; i++) {
        //Tạo thông tin dòng
        if (j % 2 == 0) { var tr = '<tr class=\"trc\">'; }
        else { { var tr = '<tr class=\"trl\">'; } };
        //Thêm thông tin cột cho dòng
        console.log(result[i]);
        var td = '<td>' + result[i].id + '</td>'
            + '<td>' + result[i].content + '</td>'
            + '<td>' + result[i].authorID + '</td> '
            + '<td>' + result[i].articleID + '</td> '
            + '<td><button onclick="EditComment(\'' + i + '\')" class="btn btn-primary"></button></td>'
            + '<td><button onclick="DeleteComment(\'' + result[i].id + '\')" class="btn btn-danger"></button></td>'
            ;
        //Mở rộng nội dung dòng
        tr += td + '</tr>';
        j++;
        $('tbody').append(tr);
    }

}
function DeleteComment(id) {

    console.log("Xóa nè");
    $.ajax({
        url: 'http://localhost:5114/api/comment?id=' + id,
        method: 'DELETE',
        contentType: 'application/json',
        dataType: "json",
        success: function (result) {
            // handle success

            location.reload(true);
        },
        error: function (request, msg, error) {
            // handle failure
        }
    });
}
function CloseEditCommentConfirm(){ $("#show").css("display", "none");}
var editID;
function EditCommentConfirm() {

    console.log("Edit!!!");
    $.ajax({
        url: 'http://localhost:5114/api/comment?id=' + editID,
        method: 'PUT',
        contentType: 'application/json',
        data: JSON.stringify({
            content: $("#Content").val(),
            authorID: $("#AuthorID").val(),
            articleID: $("#ArticleID").val(),
        }),
        dataType: "json",
        success: function (result) {
            // handle success

            location.reload(true);
        },
        error: function (request, msg, error) {
            // handle failure
        }
    });
}
function EditComment(p) {
    console.log(p);
    console.log(dataget[p]);
    editID=dataget[p].id;
    $("#show").css("display", "block");
    $("#ID").val(dataget[p].id);
    $("#Content").val(dataget[p].content);
    $("#AuthorID").val(dataget[p].authorID);
    $("#ArticleID").val(dataget[p].articleID);
}