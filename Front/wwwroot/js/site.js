$(document).ready(
    function () {
        $(".btnSeeComments").each(
            function (index, element) {
                $(element).on("click",
                    function () {
                        var val = this.id.replace("btnSeeComments_", "");
                        CommentsByPhotoId(val);
                    }
                );
            }
        );
    }
);

function CommentsByPhotoId(id) {
    var request = $.ajax(
        {
            url: $("#base_path").val() + "Music/Comments/" + id,
            method: "GET",
            dataType: "html"
        }
    );
    request.done(
        function (view) {
            $("#comments").html(view);
            window.scrollTo(0, document.body.scrollHeight);
        }
    );

    request.fail(
        function (jqXHR, textStatus) {
            alert("Request failed: " + textStatus);
        }
    );
}