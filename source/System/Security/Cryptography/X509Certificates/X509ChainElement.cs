using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B1 RID: 177
	[global::Cpp2ILInjected.Token(Token = "0x200010F")]
	public class X509ChainElement
	{
		// Token: 0x0600058B RID: 1419 RVA: 0x00003E06 File Offset: 0x00002006
		[global::Cpp2ILInjected.Token(Token = "0x6000636")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED808C", Offset = "0x1ED808C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal X509ChainElement(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00003E09 File Offset: 0x00002009
		[global::Cpp2ILInjected.Token(Token = "0x1700014F")]
		public X509Certificate2 Certificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000637")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED80F8", Offset = "0x1ED80F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00003E0C File Offset: 0x0000200C
		[global::Cpp2ILInjected.Token(Token = "0x17000150")]
		public X509ChainStatus[] ChainElementStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000638")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED8100", Offset = "0x1ED8100", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00003E0F File Offset: 0x0000200F
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00003E12 File Offset: 0x00002012
		[global::Cpp2ILInjected.Token(Token = "0x17000151")]
		internal X509ChainStatusFlags StatusFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000639")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED8108", Offset = "0x1ED8108", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600063A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED8110", Offset = "0x1ED8110", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00003E15 File Offset: 0x00002015
		[global::Cpp2ILInjected.Token(Token = "0x600063B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8118", Offset = "0x1ED8118", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Count(X509ChainStatusFlags flags)
		{
			throw null;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00003E18 File Offset: 0x00002018
		[global::Cpp2ILInjected.Token(Token = "0x600063C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED813C", Offset = "0x1ED813C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(string))]
		private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask)
		{
			throw null;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00003E1B File Offset: 0x0000201B
		[global::Cpp2ILInjected.Token(Token = "0x600063D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8324", Offset = "0x1ED8324", Length = "0x458")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "WrapUp", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainStatus), Member = "GetInformation", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void UncompressFlags()
		{
			throw null;
		}

		// Token: 0x0400039E RID: 926
		[global::Cpp2ILInjected.Token(Token = "0x4000508")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private X509Certificate2 certificate;

		// Token: 0x0400039F RID: 927
		[global::Cpp2ILInjected.Token(Token = "0x4000509")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private X509ChainStatus[] status;

		// Token: 0x040003A0 RID: 928
		[global::Cpp2ILInjected.Token(Token = "0x400050A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string info;

		// Token: 0x040003A1 RID: 929
		[global::Cpp2ILInjected.Token(Token = "0x400050B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private X509ChainStatusFlags compressed_status_flags;
	}
}
