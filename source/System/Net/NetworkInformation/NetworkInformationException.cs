using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002A1")]
	[Serializable]
	public class NetworkInformationException : Win32Exception
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001285")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C8C0", Offset = "0x1E1C8C0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommonUnixIPGlobalProperties), Member = "get_DomainName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NetworkInformationException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001286")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C924", Offset = "0x1E1C924", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000445")]
		public override int ErrorCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001287")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1C92C", Offset = "0x1E1C92C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
