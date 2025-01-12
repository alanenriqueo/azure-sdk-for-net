// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Details of the Credentials used to connect to Backend. </summary>
    public partial class BackendCredentialsContract
    {
        /// <summary> Initializes a new instance of BackendCredentialsContract. </summary>
        public BackendCredentialsContract()
        {
            CertificateIds = new ChangeTrackingList<string>();
            Certificate = new ChangeTrackingList<string>();
            Query = new ChangeTrackingDictionary<string, IList<string>>();
            Header = new ChangeTrackingDictionary<string, IList<string>>();
        }

        /// <summary> Initializes a new instance of BackendCredentialsContract. </summary>
        /// <param name="certificateIds"> List of Client Certificate Ids. </param>
        /// <param name="certificate"> List of Client Certificate Thumbprints. Will be ignored if certificatesIds are provided. </param>
        /// <param name="query"> Query Parameter description. </param>
        /// <param name="header"> Header Parameter description. </param>
        /// <param name="authorization"> Authorization header authentication. </param>
        internal BackendCredentialsContract(IList<string> certificateIds, IList<string> certificate, IDictionary<string, IList<string>> query, IDictionary<string, IList<string>> header, BackendAuthorizationHeaderCredentials authorization)
        {
            CertificateIds = certificateIds;
            Certificate = certificate;
            Query = query;
            Header = header;
            Authorization = authorization;
        }

        /// <summary> List of Client Certificate Ids. </summary>
        public IList<string> CertificateIds { get; }
        /// <summary> List of Client Certificate Thumbprints. Will be ignored if certificatesIds are provided. </summary>
        public IList<string> Certificate { get; }
        /// <summary> Query Parameter description. </summary>
        public IDictionary<string, IList<string>> Query { get; }
        /// <summary> Header Parameter description. </summary>
        public IDictionary<string, IList<string>> Header { get; }
        /// <summary> Authorization header authentication. </summary>
        public BackendAuthorizationHeaderCredentials Authorization { get; set; }
    }
}
