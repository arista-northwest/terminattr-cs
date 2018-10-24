// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: openconfig.proto
// </auto-generated>
// Original file comments:
//
// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Openconfig {
  public static partial class OpenConfig
  {
    static readonly string __ServiceName = "openconfig.OpenConfig";

    static readonly grpc::Marshaller<global::Openconfig.GetRequest> __Marshaller_openconfig_GetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Openconfig.GetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Openconfig.GetResponse> __Marshaller_openconfig_GetResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Openconfig.GetResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Openconfig.GetModelsRequest> __Marshaller_openconfig_GetModelsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Openconfig.GetModelsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Openconfig.GetModelsResponse> __Marshaller_openconfig_GetModelsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Openconfig.GetModelsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Openconfig.SetRequest> __Marshaller_openconfig_SetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Openconfig.SetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Openconfig.SetResponse> __Marshaller_openconfig_SetResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Openconfig.SetResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Openconfig.SubscribeRequest> __Marshaller_openconfig_SubscribeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Openconfig.SubscribeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Openconfig.SubscribeResponse> __Marshaller_openconfig_SubscribeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Openconfig.SubscribeResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Openconfig.GetRequest, global::Openconfig.GetResponse> __Method_Get = new grpc::Method<global::Openconfig.GetRequest, global::Openconfig.GetResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_openconfig_GetRequest,
        __Marshaller_openconfig_GetResponse);

    static readonly grpc::Method<global::Openconfig.GetModelsRequest, global::Openconfig.GetModelsResponse> __Method_GetModels = new grpc::Method<global::Openconfig.GetModelsRequest, global::Openconfig.GetModelsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetModels",
        __Marshaller_openconfig_GetModelsRequest,
        __Marshaller_openconfig_GetModelsResponse);

    static readonly grpc::Method<global::Openconfig.SetRequest, global::Openconfig.SetResponse> __Method_Set = new grpc::Method<global::Openconfig.SetRequest, global::Openconfig.SetResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Set",
        __Marshaller_openconfig_SetRequest,
        __Marshaller_openconfig_SetResponse);

    static readonly grpc::Method<global::Openconfig.SubscribeRequest, global::Openconfig.SubscribeResponse> __Method_Subscribe = new grpc::Method<global::Openconfig.SubscribeRequest, global::Openconfig.SubscribeResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Subscribe",
        __Marshaller_openconfig_SubscribeRequest,
        __Marshaller_openconfig_SubscribeResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Openconfig.OpenconfigReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of OpenConfig</summary>
    public abstract partial class OpenConfigBase
    {
      /// <summary>
      /// Get requests a single snapshot of specified data.  A Get request may
      /// contain a hint that the request will be repeated (i.e., polling).
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Openconfig.GetResponse> Get(global::Openconfig.GetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// GetModels returns information about the YANG models supported by the
      /// target.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Openconfig.GetModelsResponse> GetModels(global::Openconfig.GetModelsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Set is the primary function for sending configuration data to the target.
      /// It sets the paths contained in the SetRequest to the specified values. If
      /// any of the paths are invalid, or are read-only, the SetResponse will
      /// return an error. All paths in the SetRequest must be valid or the entire
      /// request must be rejected. If a path specifies an internal node, rather than
      /// a leaf, then the value must be the values of the node's children encoded
      /// in JSON. Binary data in the tree must be base64 encoded, but if a path
      /// specifies a leaf of binary type, it may be sent as binary. See SetRequest
      /// for further explanation on the atomicity and idempotency of a Set
      /// operation.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Openconfig.SetResponse> Set(global::Openconfig.SetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Subscribe subscribes for streaming updates.  Streaming updates are provided
      /// as a series of Notifications, each of which update a portion of the tree.
      /// The initial SubscribeRequest contains a SubscriptionList, described below.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task Subscribe(grpc::IAsyncStreamReader<global::Openconfig.SubscribeRequest> requestStream, grpc::IServerStreamWriter<global::Openconfig.SubscribeResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for OpenConfig</summary>
    public partial class OpenConfigClient : grpc::ClientBase<OpenConfigClient>
    {
      /// <summary>Creates a new client for OpenConfig</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OpenConfigClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OpenConfig that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OpenConfigClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OpenConfigClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OpenConfigClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Get requests a single snapshot of specified data.  A Get request may
      /// contain a hint that the request will be repeated (i.e., polling).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Openconfig.GetResponse Get(global::Openconfig.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get requests a single snapshot of specified data.  A Get request may
      /// contain a hint that the request will be repeated (i.e., polling).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Openconfig.GetResponse Get(global::Openconfig.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Get requests a single snapshot of specified data.  A Get request may
      /// contain a hint that the request will be repeated (i.e., polling).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Openconfig.GetResponse> GetAsync(global::Openconfig.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get requests a single snapshot of specified data.  A Get request may
      /// contain a hint that the request will be repeated (i.e., polling).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Openconfig.GetResponse> GetAsync(global::Openconfig.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// GetModels returns information about the YANG models supported by the
      /// target.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Openconfig.GetModelsResponse GetModels(global::Openconfig.GetModelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetModels(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetModels returns information about the YANG models supported by the
      /// target.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Openconfig.GetModelsResponse GetModels(global::Openconfig.GetModelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetModels, null, options, request);
      }
      /// <summary>
      /// GetModels returns information about the YANG models supported by the
      /// target.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Openconfig.GetModelsResponse> GetModelsAsync(global::Openconfig.GetModelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetModelsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetModels returns information about the YANG models supported by the
      /// target.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Openconfig.GetModelsResponse> GetModelsAsync(global::Openconfig.GetModelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetModels, null, options, request);
      }
      /// <summary>
      /// Set is the primary function for sending configuration data to the target.
      /// It sets the paths contained in the SetRequest to the specified values. If
      /// any of the paths are invalid, or are read-only, the SetResponse will
      /// return an error. All paths in the SetRequest must be valid or the entire
      /// request must be rejected. If a path specifies an internal node, rather than
      /// a leaf, then the value must be the values of the node's children encoded
      /// in JSON. Binary data in the tree must be base64 encoded, but if a path
      /// specifies a leaf of binary type, it may be sent as binary. See SetRequest
      /// for further explanation on the atomicity and idempotency of a Set
      /// operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Openconfig.SetResponse Set(global::Openconfig.SetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Set(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Set is the primary function for sending configuration data to the target.
      /// It sets the paths contained in the SetRequest to the specified values. If
      /// any of the paths are invalid, or are read-only, the SetResponse will
      /// return an error. All paths in the SetRequest must be valid or the entire
      /// request must be rejected. If a path specifies an internal node, rather than
      /// a leaf, then the value must be the values of the node's children encoded
      /// in JSON. Binary data in the tree must be base64 encoded, but if a path
      /// specifies a leaf of binary type, it may be sent as binary. See SetRequest
      /// for further explanation on the atomicity and idempotency of a Set
      /// operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Openconfig.SetResponse Set(global::Openconfig.SetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Set, null, options, request);
      }
      /// <summary>
      /// Set is the primary function for sending configuration data to the target.
      /// It sets the paths contained in the SetRequest to the specified values. If
      /// any of the paths are invalid, or are read-only, the SetResponse will
      /// return an error. All paths in the SetRequest must be valid or the entire
      /// request must be rejected. If a path specifies an internal node, rather than
      /// a leaf, then the value must be the values of the node's children encoded
      /// in JSON. Binary data in the tree must be base64 encoded, but if a path
      /// specifies a leaf of binary type, it may be sent as binary. See SetRequest
      /// for further explanation on the atomicity and idempotency of a Set
      /// operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Openconfig.SetResponse> SetAsync(global::Openconfig.SetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Set is the primary function for sending configuration data to the target.
      /// It sets the paths contained in the SetRequest to the specified values. If
      /// any of the paths are invalid, or are read-only, the SetResponse will
      /// return an error. All paths in the SetRequest must be valid or the entire
      /// request must be rejected. If a path specifies an internal node, rather than
      /// a leaf, then the value must be the values of the node's children encoded
      /// in JSON. Binary data in the tree must be base64 encoded, but if a path
      /// specifies a leaf of binary type, it may be sent as binary. See SetRequest
      /// for further explanation on the atomicity and idempotency of a Set
      /// operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Openconfig.SetResponse> SetAsync(global::Openconfig.SetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Set, null, options, request);
      }
      /// <summary>
      /// Subscribe subscribes for streaming updates.  Streaming updates are provided
      /// as a series of Notifications, each of which update a portion of the tree.
      /// The initial SubscribeRequest contains a SubscriptionList, described below.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Openconfig.SubscribeRequest, global::Openconfig.SubscribeResponse> Subscribe(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Subscribe(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Subscribe subscribes for streaming updates.  Streaming updates are provided
      /// as a series of Notifications, each of which update a portion of the tree.
      /// The initial SubscribeRequest contains a SubscriptionList, described below.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Openconfig.SubscribeRequest, global::Openconfig.SubscribeResponse> Subscribe(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Subscribe, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OpenConfigClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OpenConfigClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(OpenConfigBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_GetModels, serviceImpl.GetModels)
          .AddMethod(__Method_Set, serviceImpl.Set)
          .AddMethod(__Method_Subscribe, serviceImpl.Subscribe).Build();
    }

  }
}
#endregion
