function addArticle() {
    console.log("add")
    var article={
        title: $("#InputTitle").val(),
        content: $("#InputContent").val(),
        viewCount: $("#InputViewCount").val(),
        authorID: $("#InputAuthorID").val(),
        categoryID: $("#InputCategoryID").val()
    }
    console.log(article);
    $.ajax({
        url: "http://localhost:5114/api/article",
        type: "POST",
        contentType: 'application/json',
        dataType: "json",
        data: JSON.stringify({
            title: $("#InputTitle").val(),
            content: $("#InputContent").val(),
            viewCount: $("#InputViewCount").val(),
            authorID: $("#InputAuthorID").val(),
            categoryID: $("#InputCategoryID").val(),
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
