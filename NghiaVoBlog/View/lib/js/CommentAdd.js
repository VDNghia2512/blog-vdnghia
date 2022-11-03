function addComment() {
    console.log("add")
    var article={
        content: $("#InputContent").val(),
        authorID: $("#InputAuthorID").val(),
        articleID: $("#InputArticleID").val()
    }
    console.log(article);
    $.ajax({
        url: "http://localhost:5114/api/comment",
        type: "POST",
        contentType: 'application/json',
        dataType: "json",
        data: JSON.stringify({
            content: $("#InputContent").val(),
            authorID: $("#InputAuthorID").val(),
            articleID: $("#InputArticleID").val(),
        }),
        success: function (msg) {
            if (msg) {
                alert("success");
                location.reload(true);
            } else {
                alert("Cannot add to list !");
            }
        }
    });
}
