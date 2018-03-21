$(document).ready(function() {
    // make images draggable
    $('.image').draggable();

    // give each image a random color
    var colors = ["red", "blue", "green", "yellow", "orange"];
    var images = [$('#top-left'), $('#top-mid'), $('#top-right'), $('#bottom-left'), $('#bottom-mid'), $('#bottom-right')];

    for (let i = 0; i < images.length; i++) {
        images[i].css('backgroundColor', colors[Math.floor(Math.random() * colors.length)]);
    }
});
