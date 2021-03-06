﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyTrip.DataAccessLayer.Search
{
    /// <summary>
    /// Class to represent the non-availability of Flight Exception
    /// </summary>
    public class FlightAvailabilityDAOException : ApplicationException
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public FlightAvailabilityDAOException()
        {

        }

        /// <summary>
        /// Parameterized Constructor - Which takes a message
        /// </summary>
        /// <param name="message"></param>
        public FlightAvailabilityDAOException(string message) : base(message)
        {

        }

        /// <summary>
        /// Parameterized Constructor - Which takes a message and then inner exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public FlightAvailabilityDAOException(string message, Exception ex)
            : base(message, ex)
        {

        }
    }
}
