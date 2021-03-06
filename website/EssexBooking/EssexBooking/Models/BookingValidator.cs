﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssexBooking.Models
{
    public class BookingValidator
    {
        public List<String> errors { get; set; }

        public BookingValidator()
        {
            errors = new List<string>();
        }

        private bool ValidateTravel(DateTime startDate, int travelType)
        {
            if (travelType == 2)
            {

                if ( !(startDate.DayOfWeek == DayOfWeek.Wednesday || startDate.DayOfWeek == DayOfWeek.Saturday))
                {
                    errors.Add("cannot fly on days other than Wednesday or Saturday");
                    return false;
                }
            }

            return true;
        }

        private bool ValidateRooms(int single_rooms, int double_rooms){
            if (single_rooms + double_rooms == 0)
            {
                errors.Add("There needs to be at least one room");
                return false;
            }
            return true;
        }

        public bool Validate(BookingRequest br){
            return ValidateTravel(br.start_date, br.travel_type_id) && ValidateRooms(br.single_rooms, br.double_rooms);
        }

    }
}