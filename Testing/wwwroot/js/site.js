// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function DeleteSong(id) {
    if (window.confirm("Are you sure you want to delete?"))
        {
        $.post("/Songs/Delete", { id: id }, function (res) {
            alert("Song has been delete successfully.");
            location.href = "/Songs/Index"
        });
    }
}
