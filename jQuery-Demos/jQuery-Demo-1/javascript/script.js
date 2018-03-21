$(document).ready(function() {
    // make images draggable
    $('.image').draggable();

    // give each image a random color
    var colors = ["red", "blue", "green", "yellow", "orange"];
    var images = [$('#top-left'), $('#top-mid'), $('#top-right'), $('#bottom-left'), $('#bottom-mid'), $('#bottom-right')];

    for (let i = 0; i < images.length; i++) {
        images[i].css('backgroundColor', colors[Math.floor(Math.random() * colors.length)]);
    }

    // make image snap into determined locations
    $('.image').on('mouseup', function() {
        snapToPlace($(this).position());
    });

    function populate2DLocationArray() {
        // Possible locations where the image can snap
        var snappingLoctions = [
            $('#s-top-left').position(), $('#s-top-mid').position(), $('#s-top-right').position(),
            $('#s-bottom-left').position(), $('#s-bottom-mid').position(), $('#s-bottom-right').position()
        ];

        var locationCoords = [];

        for (let i = 0; i < snappingLoctions.length; i++) {
            locationCoords[i] = [snappingLoctions[i].left, snappingLoctions[i].top];
        }

        // Return 2d array of coords
        return locationCoords;
    }

    // custom snapping method
    function snapToPlace(currentPos) {
        // 2D array of x/y locations of snapping points
        var possibleLocations = populate2DLocationArray();

        // Current position of currently selected element
        var imageX = currentPos.left;
        var imageY = currentPos.top;

        var closestX, closestY = Infinity;

        // Find closest possible location to snap to
        for (let i = 0; i < possibleLocations.length; i++) {
            if (/* check if possible locations[i] is closer than X and Y */) {

            }
        }
    };
});
