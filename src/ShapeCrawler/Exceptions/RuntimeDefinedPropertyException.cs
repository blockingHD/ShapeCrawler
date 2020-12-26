﻿using ShapeCrawler.Enums;

namespace ShapeCrawler.Exceptions
{
    /// <summary>
    /// Thrown while attempting to access runtime defined property, but it does not exist for the current object.
    /// </summary>
    public class RuntimeDefinedPropertyException : SlideDotNetException
    {
        #region Constructors

        public RuntimeDefinedPropertyException(string message) 
            : base(message, ExceptionCodes.RuntimeDefinedPropertyException) { }

        public RuntimeDefinedPropertyException()
        {
        }

        public RuntimeDefinedPropertyException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        #endregion Constructors
    }
}