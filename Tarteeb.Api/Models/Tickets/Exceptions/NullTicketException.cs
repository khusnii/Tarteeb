﻿//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

using Xeptions;

namespace Tarteeb.Api.Models.Tickets.Exceptions
{
    public class NullTicketException : Xeption
    {
        public NullTicketException() : base(message: "Ticket is null.")
        { }
    }
}
