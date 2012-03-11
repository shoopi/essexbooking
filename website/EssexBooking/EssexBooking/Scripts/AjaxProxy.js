﻿function AddHotelToCart(hotel_id, callback) {
    $.ajax({
        data: { hotel_id: hotel_id },
        url: '/Ajax/AddHotelToCart',
        cache: false,
        success: callback
    });
}
/*
function RemoveHotelFromCart(hotel_id, callback) {
    $.ajax({
        data: { hotel_id: hotel_id },
        url: '/Ajax/RemoveHotelFromCart',
        cache: false,
        success: callback
    });
}
*/

function RemoveBookingFromCart(temp_id, callback) {
    $.ajax({
        data: { temp_id: temp_id },
        url: '/Ajax/RemoveBookingFromCart',
        cache: false,
        success: callback
    });
}

function UpdateBooking(data, callback) {
    $.ajax({
        data: data,
        url: '/Ajax/UpdateBooking',
        type: "POST",
        success: callback,
        dataType:"json"
    });

}

function AddExtraToBooking(temp_id, extra_id, number, extra_date, callback) {
    $.ajax({
        data: { 'temp_id': temp_id, 'extra_id': extra_id, 'number': number, 'extra_date': extra_date},
            url: '/Ajax/AddExtraToBooking',
            type: "POST",
            success: callback
        });
    }

    function setGuests(temp_id, guests, callback) {
        $.ajax({
            data: { 'temp_id': temp_id, 'guests': guests },
            url: '/Ajax/SetGuests',
            type: "POST",
            success: callback
        });
    }

    function setRooms(temp_id, guests, callback) {
        $.ajax({
            data: { 'temp_id': temp_id, 'guests': guests },
            url: '/Ajax/SetRooms',
            type: "POST",
            success: callback
        });
    }

    function setDoubles(temp_id, rooms, guests, callback) {
        $.ajax({
            data: { 'temp_id': temp_id, 'rooms': rooms,  'guests': guests},
            url: '/Ajax/SetDoubles',
            type: "POST",
            success: callback
        });
    }
