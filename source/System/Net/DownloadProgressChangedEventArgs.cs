using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000182")]
	public class DownloadProgressChangedEventArgs : ProgressChangedEventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03A74", Offset = "0x1F03A74", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProgressChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal DownloadProgressChangedEventArgs(int progressPercentage, object userToken, long bytesReceived, long totalBytesToReceive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000200")]
		public long BytesReceived
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000A02")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F088C8", Offset = "0x1F088C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000201")]
		public long TotalBytesToReceive
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000A03")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F088D0", Offset = "0x1F088D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F088D8", Offset = "0x1F088D8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal DownloadProgressChangedEventArgs()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly long <BytesReceived>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly long <TotalBytesToReceive>k__BackingField;
	}
}
