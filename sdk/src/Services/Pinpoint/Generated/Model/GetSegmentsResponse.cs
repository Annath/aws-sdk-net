/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// This is the response object from the GetSegments operation.
    /// </summary>
    public partial class GetSegmentsResponse : AmazonWebServiceResponse
    {
        private SegmentsResponse _segmentsResponse;

        /// <summary>
        /// Gets and sets the property SegmentsResponse.
        /// </summary>
        public SegmentsResponse SegmentsResponse
        {
            get { return this._segmentsResponse; }
            set { this._segmentsResponse = value; }
        }

        // Check to see if SegmentsResponse property is set
        internal bool IsSetSegmentsResponse()
        {
            return this._segmentsResponse != null;
        }

    }
}