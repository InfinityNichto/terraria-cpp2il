using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000183")]
	public class UploadProgressChangedEventArgs : ProgressChangedEventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F03A34", Offset = "0x1F03A34", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProgressChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal UploadProgressChangedEventArgs(int progressPercentage, object userToken, long bytesSent, long totalBytesToSend, long bytesReceived, long totalBytesToReceive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000202")]
		public long BytesReceived
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000A06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08910", Offset = "0x1F08910", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000203")]
		public long TotalBytesToReceive
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000A07")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08918", Offset = "0x1F08918", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000204")]
		public long BytesSent
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000A08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08920", Offset = "0x1F08920", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000205")]
		public long TotalBytesToSend
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000A09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08928", Offset = "0x1F08928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08930", Offset = "0x1F08930", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal UploadProgressChangedEventArgs()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly long <BytesReceived>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly long <TotalBytesToReceive>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly long <BytesSent>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly long <TotalBytesToSend>k__BackingField;
	}
}
