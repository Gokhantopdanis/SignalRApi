﻿namespace SignalRWebUI.Dtos.BookingDto
{
    public class GetBookingDto
    {
        public int BookingID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public int PersonCount { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
