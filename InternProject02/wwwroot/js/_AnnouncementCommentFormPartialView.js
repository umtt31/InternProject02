$(document).ready(() => {

    let loadComments = () => {
        $.ajax({
            type: "GET",
            url: `LoadComment`,
            success: data => {
                $("#comments").empty()
                $.each(data, (index, item) => {
                    var comment = `<div class="card">
                                        <div class="card-header">
                                            ${item.AnnouncementCommentName}
                                        </div>
                                        <div class="card-body">
                                            <blockquote class="blockquote mb-0">
                                                <p>${item.AnnouncementCommentBody}</p>
                                                <footer class="blockquote-footer">${item.AnnouncementCommentCreateDate}</footer>
                                            </blockquote>
                                         </div>
                                     </div>`

                    $("#comments").prepend(comment);
                })
            },
            error: e => { console.log(e) },
        })
    }

    loadComments()

    $("#btnSave").click(() => {
        var name = $("#Name").val();
        var comment = $("#Comment").val();
        var announcementId = $("#announcement_id").val()

        var JsonData = { "AnnouncementCommentName": name, "AnnouncementCommentBody": comment, "AnnouncementId": announcementId }
        console.log(JsonData)

        $.ajax({
            type: "POST",
            url: "SaveComment",
            data: JsonData,
            success: data => { console.log(data); loadComments(); $("#Name").val(""); $("#Comment").val(""); },
            error: err => { console.log(err.message) },
        })
    });
})
