using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000FE RID: 254
	[global::Cpp2ILInjected.Token(Token = "0x2000182")]
	public class DownloadProgressChangedEventArgs : ProgressChangedEventArgs
	{
		// Token: 0x060008F6 RID: 2294 RVA: 0x000047B1 File Offset: 0x000029B1
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

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x000047B4 File Offset: 0x000029B4
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

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x000047B7 File Offset: 0x000029B7
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

		// Token: 0x060008F9 RID: 2297 RVA: 0x000047BA File Offset: 0x000029BA
		[global::Cpp2ILInjected.Token(Token = "0x6000A04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F088D8", Offset = "0x1F088D8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal DownloadProgressChangedEventArgs()
		{
			throw null;
		}

		// Token: 0x04000594 RID: 1428
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly long <BytesReceived>k__BackingField;

		// Token: 0x04000595 RID: 1429
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly long <TotalBytesToReceive>k__BackingField;
	}
}
