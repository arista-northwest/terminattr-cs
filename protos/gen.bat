
@rem test

@rem %UserProfile%\.nuget\packages\grpc.tools\1.15.0\tools\windows_x86\protoc.exe -I. --csharp_out ../src/ --grpc_out ../src/ openconfig.proto --plugin=protoc-gen-grpc=%UserProfile%\.nuget\packages\grpc.tools\1.15.0\tools\windows_x86\grpc_csharp_plugin.exe

%UserProfile%\.nuget\packages\grpc.tools\1.15.0\tools\windows_x86\protoc.exe -I. --csharp_out ../src/ --grpc_out ../src/ gnmi.proto --plugin=protoc-gen-grpc=%UserProfile%\.nuget\packages\grpc.tools\1.15.0\tools\windows_x86\grpc_csharp_plugin.exe

%UserProfile%\.nuget\packages\grpc.tools\1.15.0\tools\windows_x86\protoc.exe -I. --csharp_out ../src/ --grpc_out ../src/ github.com\openconfig\gnmi\proto\gnmi_ext\gnmi_ext.proto --plugin=protoc-gen-grpc=%UserProfile%\.nuget\packages\grpc.tools\1.15.0\tools\windows_x86\grpc_csharp_plugin.exe 