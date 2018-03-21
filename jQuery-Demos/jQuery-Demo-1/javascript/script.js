$(document).ready(function() {
    // make images draggable
    $('.image').draggable();

    // give each image a random color
    var colors = ["red", "blue", "green", "yellow", "orange", "crimson", "teal"];
    var images = [$('#top-left'), $('#top-mid'), $('#top-right'), $('#bottom-left'), $('#bottom-mid'), $('#bottom-right')];

    for (let i = 0; i < images.length; i++) {
        images[i].css('backgroundColor', colors[Math.floor(Math.random() * colors.length)]);
    }

    // make image snap into determined locations
    $('.image').on('mouseup', function() {
        snapToPlace($(this));
    });

    // Method to populate array with x & y coords
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

    // Method to systematically locate the closest snapping point
    function findClosestSnappingPoint(nowX, nowY, possibleLocations) {
        // Current coords of the image being dragged
        var currentX = nowX;
        var currentY = nowY;

        var closestX = Infinity, closestY = Infinity;

        for (let i = 0; i < possibleLocations.length; i++) {
            // check distance
        }

        return [closestX, closestY];
    }

    // Method to snap draggable icon into place
    function setFixedLocation(item, moveX, moveY) {
        // set positions here
    }

    // custom snapping method
    function snapToPlace(icon) {
        // 2D array of x/y locations of snapping points
        var possibleLocations = populate2DLocationArray();

        // Current position of currently selected element
        var imageX = icon.position().left;
        var imageY = icon.position().top;

        var closestPoint = findClosestSnappingPoint(imageX, imageY, possibleLocations);

        // Pin draggable icon to closest suitable position
        setFixedLocation(icon, closestPoint[0], closestPoint[1]);
    };
});
