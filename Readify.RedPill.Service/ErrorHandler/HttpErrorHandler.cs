using System;
using System.Net;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Readify.RedPill.Service
{
    /// <summary>
    /// HttpErrorHandler
    /// </summary>
    public class HttpErrorHandler : IErrorHandler
    {
        /// <summary>
        /// Handles the error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <returns></returns>
        public bool HandleError(Exception error)
        {
            return false;
        }

        /// <summary>
        /// Provides the fault.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <param name="version">The version.</param>
        /// <param name="fault">The fault.</param>
        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            if (fault != null)
            {
                HttpResponseMessageProperty properties = new HttpResponseMessageProperty();
                properties.StatusCode = HttpStatusCode.InternalServerError;
                fault.Properties.Add(HttpResponseMessageProperty.Name, properties);
            }
        }
    }
}
