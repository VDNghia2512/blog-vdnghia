var dataget;
$(document).ready(function () {

    $.ajax({
        url: 'http://localhost:5114/api/article',
        type: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
        success: function (result) {
            dataget = result;
            console.log(result);
            $('tbody').empty();
            reloadArticlelist(result);
            $('#ArticleList').DataTable()
        }
    });
});
function reloadArticlelist(result) {
    var j = 0;
    //Duyệt kết quả trả về
    for (let i = 0; i < result.length; i++) {
        //Tạo thông tin dòng
        if (j % 2 == 0) { var tr = '<tr class=\"trc\">'; }
        else { { var tr = '<tr class=\"trl\">'; } };
        //Thêm thông tin cột cho dòng
        console.log(result[i]);
        var td = '<td>' + result[i].id + '</td>'
            + '<td>' + result[i].title + '</td> '
            + '<td>' + result[i].content + '</td>'
            + '<td>' + result[i].viewCount + '</td> '
            + '<td>' + result[i].authorID + '</td> '
            + '<td>' + result[i].categoryID + '</td> '
            + '<td><button onclick="EditArticle(\'' + i + '\')" class="btn btn-primary"></button></td>'
            + '<td><button onclick="DeleteArticle(\'' + result[i].id + '\')" class="btn btn-danger"></button></td>'
            ;
        //Mở rộng nội dung dòng
        tr += td + '</tr>';
        j++;
        $('tbody').append(tr);
    }

}
function DeleteArticle(id) {

    console.log("Xóa nè");
    $.ajax({
        url: 'http://localhost:5114/api/article?id=' + id,
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
function CloseEditArticleConfirm(){ $("#show").css("display", "none");}
var editID;
function EditArticleConfirm() {

    console.log("Edit!!!");
    $.ajax({
        url: 'http://localhost:5114/api/article?id=' + editID,
        method: 'PUT',
        contentType: 'application/json',
        data: JSON.stringify({
            title: $("#Title").val(),
            content: $("#Content").val(),
            viewCount: $("#ViewCount").val(),
            authorID: $("#AuthorID").val(),
            categoryID: $("#CategoryID").val(),
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
function EditArticle(p) {
    console.log(p);
    console.log(dataget[p]);
    editID=dataget[p].id;
    $("#show").css("display", "block");
    $("#ID").val(dataget[p].id);
    $("#Title").val(dataget[p].title);
    $("#Content").val(dataget[p].content);
    $("#ViewCount").val(dataget[p].viewCount);
    $("#AuthorID").val(dataget[p].authorID);
    $("#CategoryID").val(dataget[p].categoryID);
}