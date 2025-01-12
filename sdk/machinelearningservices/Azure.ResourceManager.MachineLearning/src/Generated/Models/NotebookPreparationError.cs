// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The NotebookPreparationError. </summary>
    public partial class NotebookPreparationError
    {
        /// <summary> Initializes a new instance of NotebookPreparationError. </summary>
        internal NotebookPreparationError()
        {
        }

        /// <summary> Initializes a new instance of NotebookPreparationError. </summary>
        /// <param name="errorMessage"></param>
        /// <param name="statusCode"></param>
        internal NotebookPreparationError(string errorMessage, int? statusCode)
        {
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
        }

        /// <summary> Gets the error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Gets the status code. </summary>
        public int? StatusCode { get; }
    }
}
