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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaLive.Model;
using Amazon.MediaLive.Model.Internal.MarshallTransformations;
using Amazon.MediaLive.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaLive
{
    /// <summary>
    /// Implementation for accessing MediaLive
    ///
    /// API for AWS Elemental MediaLive
    /// </summary>
    public partial class AmazonMediaLiveClient : AmazonServiceClient, IAmazonMediaLive
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaLiveMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaLiveClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonMediaLiveClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaLiveConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaLiveClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaLiveConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonMediaLiveClient Configuration Object</param>
        public AmazonMediaLiveClient(AmazonMediaLiveConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaLiveClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaLiveConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaLiveClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaLiveConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Credentials and an
        /// AmazonMediaLiveClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaLiveClient Configuration Object</param>
        public AmazonMediaLiveClient(AWSCredentials credentials, AmazonMediaLiveConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaLiveConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaLiveConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaLiveClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaLiveClient Configuration Object</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaLiveConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaLiveConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaLiveConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaLiveClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaLiveClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaLiveClient Configuration Object</param>
        public AmazonMediaLiveClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaLiveConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  BatchUpdateSchedule

        /// <summary>
        /// Update a channel schedule
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateSchedule service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchUpdateSchedule">REST API Reference for BatchUpdateSchedule Operation</seealso>
        public virtual BatchUpdateScheduleResponse BatchUpdateSchedule(BatchUpdateScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateScheduleResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateSchedule operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchUpdateSchedule">REST API Reference for BatchUpdateSchedule Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateSchedule(BatchUpdateScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateSchedule.</param>
        /// 
        /// <returns>Returns a  BatchUpdateScheduleResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchUpdateSchedule">REST API Reference for BatchUpdateSchedule Operation</seealso>
        public virtual BatchUpdateScheduleResponse EndBatchUpdateSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannel

        /// <summary>
        /// Creates a new channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInput

        /// <summary>
        /// Create an input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInput service method.</param>
        /// 
        /// <returns>The response from the CreateInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInput">REST API Reference for CreateInput Operation</seealso>
        public virtual CreateInputResponse CreateInput(CreateInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputResponseUnmarshaller.Instance;

            return Invoke<CreateInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInput operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInput">REST API Reference for CreateInput Operation</seealso>
        public virtual IAsyncResult BeginCreateInput(CreateInputRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInput.</param>
        /// 
        /// <returns>Returns a  CreateInputResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInput">REST API Reference for CreateInput Operation</seealso>
        public virtual CreateInputResponse EndCreateInput(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInputResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInputSecurityGroup

        /// <summary>
        /// Creates a Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInputSecurityGroup">REST API Reference for CreateInputSecurityGroup Operation</seealso>
        public virtual CreateInputSecurityGroupResponse CreateInputSecurityGroup(CreateInputSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateInputSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSecurityGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInputSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInputSecurityGroup">REST API Reference for CreateInputSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateInputSecurityGroup(CreateInputSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInputSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInputSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateInputSecurityGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInputSecurityGroup">REST API Reference for CreateInputSecurityGroup Operation</seealso>
        public virtual CreateInputSecurityGroupResponse EndCreateInputSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInputSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTags

        /// <summary>
        /// Create tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual CreateTagsResponse EndCreateTags(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannel

        /// <summary>
        /// Starts deletion of channel. The associated outputs are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInput

        /// <summary>
        /// Deletes the input end point
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput service method.</param>
        /// 
        /// <returns>The response from the DeleteInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        public virtual DeleteInputResponse DeleteInput(DeleteInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputResponseUnmarshaller.Instance;

            return Invoke<DeleteInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        public virtual IAsyncResult BeginDeleteInput(DeleteInputRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInput.</param>
        /// 
        /// <returns>Returns a  DeleteInputResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        public virtual DeleteInputResponse EndDeleteInput(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInputResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInputSecurityGroup

        /// <summary>
        /// Deletes an Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInputSecurityGroup">REST API Reference for DeleteInputSecurityGroup Operation</seealso>
        public virtual DeleteInputSecurityGroupResponse DeleteInputSecurityGroup(DeleteInputSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteInputSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSecurityGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInputSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInputSecurityGroup">REST API Reference for DeleteInputSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteInputSecurityGroup(DeleteInputSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInputSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInputSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteInputSecurityGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInputSecurityGroup">REST API Reference for DeleteInputSecurityGroup Operation</seealso>
        public virtual DeleteInputSecurityGroupResponse EndDeleteInputSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInputSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReservation

        /// <summary>
        /// Delete an expired reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReservation service method.</param>
        /// 
        /// <returns>The response from the DeleteReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteReservation">REST API Reference for DeleteReservation Operation</seealso>
        public virtual DeleteReservationResponse DeleteReservation(DeleteReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReservationResponseUnmarshaller.Instance;

            return Invoke<DeleteReservationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReservation operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteReservation">REST API Reference for DeleteReservation Operation</seealso>
        public virtual IAsyncResult BeginDeleteReservation(DeleteReservationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReservationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReservation.</param>
        /// 
        /// <returns>Returns a  DeleteReservationResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteReservation">REST API Reference for DeleteReservation Operation</seealso>
        public virtual DeleteReservationResponse EndDeleteReservation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReservationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTags

        /// <summary>
        /// Removes tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannel

        /// <summary>
        /// Gets details about a channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInput

        /// <summary>
        /// Produces details about an input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput service method.</param>
        /// 
        /// <returns>The response from the DescribeInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        public virtual DescribeInputResponse DescribeInput(DescribeInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputResponseUnmarshaller.Instance;

            return Invoke<DescribeInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        public virtual IAsyncResult BeginDescribeInput(DescribeInputRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInput.</param>
        /// 
        /// <returns>Returns a  DescribeInputResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        public virtual DescribeInputResponse EndDescribeInput(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInputResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInputSecurityGroup

        /// <summary>
        /// Produces a summary of an Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputSecurityGroup">REST API Reference for DescribeInputSecurityGroup Operation</seealso>
        public virtual DescribeInputSecurityGroupResponse DescribeInputSecurityGroup(DescribeInputSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeInputSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputSecurityGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInputSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputSecurityGroup">REST API Reference for DescribeInputSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeInputSecurityGroup(DescribeInputSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInputSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInputSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DescribeInputSecurityGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputSecurityGroup">REST API Reference for DescribeInputSecurityGroup Operation</seealso>
        public virtual DescribeInputSecurityGroupResponse EndDescribeInputSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInputSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOffering

        /// <summary>
        /// Get details for an offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering service method.</param>
        /// 
        /// <returns>The response from the DescribeOffering service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        public virtual DescribeOfferingResponse DescribeOffering(DescribeOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOfferingResponseUnmarshaller.Instance;

            return Invoke<DescribeOfferingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        public virtual IAsyncResult BeginDescribeOffering(DescribeOfferingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOfferingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOffering.</param>
        /// 
        /// <returns>Returns a  DescribeOfferingResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        public virtual DescribeOfferingResponse EndDescribeOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservation

        /// <summary>
        /// Get details for a reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation service method.</param>
        /// 
        /// <returns>The response from the DescribeReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        public virtual DescribeReservationResponse DescribeReservation(DescribeReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservationResponseUnmarshaller.Instance;

            return Invoke<DescribeReservationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        public virtual IAsyncResult BeginDescribeReservation(DescribeReservationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservation.</param>
        /// 
        /// <returns>Returns a  DescribeReservationResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        public virtual DescribeReservationResponse EndDescribeReservation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSchedule

        /// <summary>
        /// Get a channel schedule
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        public virtual DescribeScheduleResponse DescribeSchedule(DescribeScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduleResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedule operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        public virtual IAsyncResult BeginDescribeSchedule(DescribeScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSchedule.</param>
        /// 
        /// <returns>Returns a  DescribeScheduleResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        public virtual DescribeScheduleResponse EndDescribeSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannels

        /// <summary>
        /// Produces list of channels that have been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse EndListChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInputs

        /// <summary>
        /// Produces list of inputs that have been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputs service method.</param>
        /// 
        /// <returns>The response from the ListInputs service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputs">REST API Reference for ListInputs Operation</seealso>
        public virtual ListInputsResponse ListInputs(ListInputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputsResponseUnmarshaller.Instance;

            return Invoke<ListInputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputs operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputs">REST API Reference for ListInputs Operation</seealso>
        public virtual IAsyncResult BeginListInputs(ListInputsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInputs.</param>
        /// 
        /// <returns>Returns a  ListInputsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputs">REST API Reference for ListInputs Operation</seealso>
        public virtual ListInputsResponse EndListInputs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInputsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInputSecurityGroups

        /// <summary>
        /// Produces a list of Input Security Groups for an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the ListInputSecurityGroups service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputSecurityGroups">REST API Reference for ListInputSecurityGroups Operation</seealso>
        public virtual ListInputSecurityGroupsResponse ListInputSecurityGroups(ListInputSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<ListInputSecurityGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInputSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputSecurityGroups operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInputSecurityGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputSecurityGroups">REST API Reference for ListInputSecurityGroups Operation</seealso>
        public virtual IAsyncResult BeginListInputSecurityGroups(ListInputSecurityGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInputSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInputSecurityGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInputSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInputSecurityGroups.</param>
        /// 
        /// <returns>Returns a  ListInputSecurityGroupsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputSecurityGroups">REST API Reference for ListInputSecurityGroups Operation</seealso>
        public virtual ListInputSecurityGroupsResponse EndListInputSecurityGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInputSecurityGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOfferings

        /// <summary>
        /// List offerings available for purchase.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings service method.</param>
        /// 
        /// <returns>The response from the ListOfferings service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual ListOfferingsResponse ListOfferings(ListOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return Invoke<ListOfferingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual IAsyncResult BeginListOfferings(ListOfferingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfferings.</param>
        /// 
        /// <returns>Returns a  ListOfferingsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        public virtual ListOfferingsResponse EndListOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReservations

        /// <summary>
        /// List purchased reservations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReservations service method.</param>
        /// 
        /// <returns>The response from the ListReservations service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        public virtual ListReservationsResponse ListReservations(ListReservationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationsResponseUnmarshaller.Instance;

            return Invoke<ListReservationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReservations operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReservations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        public virtual IAsyncResult BeginListReservations(ListReservationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReservationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReservations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReservations.</param>
        /// 
        /// <returns>Returns a  ListReservationsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        public virtual ListReservationsResponse EndListReservations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReservationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Produces list of tags that have been created for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseOffering

        /// <summary>
        /// Purchase an offering and create a reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseOffering service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual PurchaseOfferingResponse PurchaseOffering(PurchaseOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseOfferingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual IAsyncResult BeginPurchaseOffering(PurchaseOfferingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseOfferingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseOfferingResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        public virtual PurchaseOfferingResponse EndPurchaseOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  StartChannel

        /// <summary>
        /// Starts an existing channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// 
        /// <returns>The response from the StartChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartChannel">REST API Reference for StartChannel Operation</seealso>
        public virtual StartChannelResponse StartChannel(StartChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChannelResponseUnmarshaller.Instance;

            return Invoke<StartChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartChannel">REST API Reference for StartChannel Operation</seealso>
        public virtual IAsyncResult BeginStartChannel(StartChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartChannel.</param>
        /// 
        /// <returns>Returns a  StartChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartChannel">REST API Reference for StartChannel Operation</seealso>
        public virtual StartChannelResponse EndStartChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<StartChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  StopChannel

        /// <summary>
        /// Stops a running channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// 
        /// <returns>The response from the StopChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopChannel">REST API Reference for StopChannel Operation</seealso>
        public virtual StopChannelResponse StopChannel(StopChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopChannelResponseUnmarshaller.Instance;

            return Invoke<StopChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopChannel">REST API Reference for StopChannel Operation</seealso>
        public virtual IAsyncResult BeginStopChannel(StopChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopChannel.</param>
        /// 
        /// <returns>Returns a  StopChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopChannel">REST API Reference for StopChannel Operation</seealso>
        public virtual StopChannelResponse EndStopChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<StopChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannel

        /// <summary>
        /// Updates a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInput

        /// <summary>
        /// Updates an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput service method.</param>
        /// 
        /// <returns>The response from the UpdateInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        public virtual UpdateInputResponse UpdateInput(UpdateInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputResponseUnmarshaller.Instance;

            return Invoke<UpdateInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        public virtual IAsyncResult BeginUpdateInput(UpdateInputRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInput.</param>
        /// 
        /// <returns>Returns a  UpdateInputResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        public virtual UpdateInputResponse EndUpdateInput(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInputResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInputSecurityGroup

        /// <summary>
        /// Update an Input Security Group's Whilelists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputSecurityGroup">REST API Reference for UpdateInputSecurityGroup Operation</seealso>
        public virtual UpdateInputSecurityGroupResponse UpdateInputSecurityGroup(UpdateInputSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateInputSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInputSecurityGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInputSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputSecurityGroup">REST API Reference for UpdateInputSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateInputSecurityGroup(UpdateInputSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInputSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInputSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInputSecurityGroup.</param>
        /// 
        /// <returns>Returns a  UpdateInputSecurityGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputSecurityGroup">REST API Reference for UpdateInputSecurityGroup Operation</seealso>
        public virtual UpdateInputSecurityGroupResponse EndUpdateInputSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInputSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}