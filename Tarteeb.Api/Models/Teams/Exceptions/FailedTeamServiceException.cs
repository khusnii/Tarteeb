﻿//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

using System;
using Xeptions;

namespace Tarteeb.Api.Models.Teams.Exceptions
{
    public class FailedTeamServiceException : Xeption
    {
        public FailedTeamServiceException(Exception innerException)
            : base(message: "Failed team service occurred, please contact support.",
                innerException)
        { }
    }
}