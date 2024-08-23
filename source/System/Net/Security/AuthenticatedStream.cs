using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net.Security
{
	// Token: 0x0200022B RID: 555
	[global::Cpp2ILInjected.Token(Token = "0x200031B")]
	public abstract class AuthenticatedStream : Stream
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x00006308 File Offset: 0x00004508
		[global::Cpp2ILInjected.Token(Token = "0x60014B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E37D1C", Offset = "0x1E37D1C", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(SslStream),
			typeof(MonoTlsSettings),
			typeof(MobileTlsProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback),
			typeof(LocalCertificateSelectionCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(MonoTlsProvider),
			typeof(MonoTlsSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
		{
			throw null;
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x0000630B File Offset: 0x0000450B
		[global::Cpp2ILInjected.Token(Token = "0x170004B6")]
		protected Stream InnerStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E37EAC", Offset = "0x1E37EAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0000630E File Offset: 0x0000450E
		[global::Cpp2ILInjected.Token(Token = "0x60014B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E37EB4", Offset = "0x1E37EB4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001277 RID: 4727
		[global::Cpp2ILInjected.Token(Token = "0x170004B7")]
		public abstract bool IsAuthenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014B3")]
			get;
		}

		// Token: 0x04000D4A RID: 3402
		[global::Cpp2ILInjected.Token(Token = "0x4001145")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Stream _InnerStream;

		// Token: 0x04000D4B RID: 3403
		[global::Cpp2ILInjected.Token(Token = "0x4001146")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _LeaveStreamOpen;
	}
}
