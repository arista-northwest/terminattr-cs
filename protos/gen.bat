
@rem test

%UserProfile%\.nuget\packages\grpc.tools\1.15.0\tools\windows_x86\protoc.exe -I. --csharp_out ../ --grpc_out ../ openconfig.proto --plugin=protoc-gen-grpc=%UserProfile%\.nuget\packages\grpc.tools\1.15.0\tools\windows_x86\grpc_csharp_plugin.exe