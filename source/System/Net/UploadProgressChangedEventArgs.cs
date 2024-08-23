using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000FF RID: 255
	[global::Cpp2ILInjected.Token(Token = "0x2000183")]
	public class UploadProgressChangedEventArgs : ProgressChangedEventArgs
	{
		// Token: 0x060008FA RID: 2298 RVA: 0x000047BD File Offset: 0x000029BD
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

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x000047C0 File Offset: 0x000029C0
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

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x000047C3 File Offset: 0x000029C3
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

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x000047C6 File Offset: 0x000029C6
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

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x000047C9 File Offset: 0x000029C9
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

		// Token: 0x060008FF RID: 2303 RVA: 0x000047CC File Offset: 0x000029CC
		[global::Cpp2ILInjected.Token(Token = "0x6000A0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08930", Offset = "0x1F08930", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal UploadProgressChangedEventArgs()
		{
			throw null;
		}

		// Token: 0x04000596 RID: 1430
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly long <BytesReceived>k__BackingField;

		// Token: 0x04000597 RID: 1431
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly long <TotalBytesToReceive>k__BackingField;

		// Token: 0x04000598 RID: 1432
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly long <BytesSent>k__BackingField;

		// Token: 0x04000599 RID: 1433
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40007A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly long <TotalBytesToSend>k__BackingField;
	}
}
