using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000DD RID: 221
	[global::Cpp2ILInjected.Token(Token = "0x2000147")]
	internal class ResponseDescription
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x000042E6 File Offset: 0x000024E6
		[global::Cpp2ILInjected.Token(Token = "0x170001A3")]
		internal bool PositiveIntermediate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECD70", Offset = "0x1EECD70", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x000042E9 File Offset: 0x000024E9
		[global::Cpp2ILInjected.Token(Token = "0x170001A4")]
		internal bool PositiveCompletion
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECD84", Offset = "0x1EECD84", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x000042EC File Offset: 0x000024EC
		[global::Cpp2ILInjected.Token(Token = "0x170001A5")]
		internal bool TransientFailure
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECD98", Offset = "0x1EECD98", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x000042EF File Offset: 0x000024EF
		[global::Cpp2ILInjected.Token(Token = "0x170001A6")]
		internal bool PermanentFailure
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECDAC", Offset = "0x1EECDAC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x000042F2 File Offset: 0x000024F2
		[global::Cpp2ILInjected.Token(Token = "0x170001A7")]
		internal bool InvalidStatusCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECDC0", Offset = "0x1EECDC0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000042F5 File Offset: 0x000024F5
		[global::Cpp2ILInjected.Token(Token = "0x60007FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EECDD4", Offset = "0x1EECDD4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReceiveState), Member = ".ctor", MemberParameters = new object[] { typeof(CommandStream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ResponseDescription()
		{
			throw null;
		}

		// Token: 0x040004D9 RID: 1241
		[global::Cpp2ILInjected.Token(Token = "0x400066C")]
		internal const int NoStatus = -1;

		// Token: 0x040004DA RID: 1242
		[global::Cpp2ILInjected.Token(Token = "0x400066D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool Multiline;

		// Token: 0x040004DB RID: 1243
		[global::Cpp2ILInjected.Token(Token = "0x400066E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int Status;

		// Token: 0x040004DC RID: 1244
		[global::Cpp2ILInjected.Token(Token = "0x400066F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string StatusDescription;

		// Token: 0x040004DD RID: 1245
		[global::Cpp2ILInjected.Token(Token = "0x4000670")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal StringBuilder StatusBuffer;

		// Token: 0x040004DE RID: 1246
		[global::Cpp2ILInjected.Token(Token = "0x4000671")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string StatusCodeString;
	}
}
