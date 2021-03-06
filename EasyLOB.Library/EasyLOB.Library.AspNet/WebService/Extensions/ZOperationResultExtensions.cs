﻿using System;
using System.Web.Services.Protocols;

namespace EasyLOB.Library.AspNet
{
    public static partial class ZOperationResultExtensions
    {
        public static void ParseExceptionWebService(this ZOperationResult operationResult, Exception exception)
        {
            if (exception is SoapException)
            {
                operationResult.ErrorMessage = exception.Message;
            }
            else
            {
                operationResult.ParseException(exception);
            }
        }
    }
}