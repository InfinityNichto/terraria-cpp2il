using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000AA RID: 170
	[global::Cpp2ILInjected.Token(Token = "0x2000107")]
	public sealed class X509Certificate2Enumerator : IEnumerator
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x00003D2B File Offset: 0x00001F2B
		[global::Cpp2ILInjected.Token(Token = "0x60005DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED5448", Offset = "0x1ED5448", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetEnumerator", ReturnType = typeof(X509Certificate2Enumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal X509Certificate2Enumerator(X509Certificate2Collection collection)
		{
			throw null;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00003D2E File Offset: 0x00001F2E
		[global::Cpp2ILInjected.Token(Token = "0x17000129")]
		public X509Certificate2 Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED559C", Offset = "0x1ED559C", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new object[]
			{
				typeof(X509Certificate2),
				typeof(X509Certificate2Collection)
			}, ReturnType = typeof(X509Certificate2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00003D31 File Offset: 0x00001F31
		[global::Cpp2ILInjected.Token(Token = "0x60005DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED5684", Offset = "0x1ED5684", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new object[]
		{
			typeof(X509Certificate2),
			typeof(X509Certificate2Collection)
		}, ReturnType = typeof(X509Certificate2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool MoveNext()
		{
			throw null;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00003D34 File Offset: 0x00001F34
		[global::Cpp2ILInjected.Token(Token = "0x1700012A")]
		private object System.Collections.IEnumerator.Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED571C", Offset = "0x1ED571C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00003D37 File Offset: 0x00001F37
		[global::Cpp2ILInjected.Token(Token = "0x60005DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED57B8", Offset = "0x1ED57B8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool System.Collections.IEnumerator.MoveNext()
		{
			throw null;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00003D3A File Offset: 0x00001F3A
		[global::Cpp2ILInjected.Token(Token = "0x60005E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED5850", Offset = "0x1ED5850", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void System.Collections.IEnumerator.Reset()
		{
			throw null;
		}

		// Token: 0x04000395 RID: 917
		[global::Cpp2ILInjected.Token(Token = "0x40004FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IEnumerator enumerator;
	}
}
