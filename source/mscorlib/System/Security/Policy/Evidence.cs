using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Policy
{
	// Token: 0x02000210 RID: 528
	[global::System.MonoTODO("Serialization format not compatible with .NET")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002A7")]
	[global::System.Serializable]
	public sealed class Evidence : global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06001539 RID: 5433 RVA: 0x000180AA File Offset: 0x000162AA
		[global::Cpp2ILInjected.Token(Token = "0x6001744")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0870", Offset = "0x1AF0870", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Evidence()
		{
			throw null;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x000180AD File Offset: 0x000162AD
		[global::System.Obsolete]
		[global::Cpp2ILInjected.Token(Token = "0x1700025A")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001745")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0878", Offset = "0x1AF0878", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x000180B0 File Offset: 0x000162B0
		[global::Cpp2ILInjected.Token(Token = "0x1700025B")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001746")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF08D4", Offset = "0x1AF08D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000180B3 File Offset: 0x000162B3
		[global::Cpp2ILInjected.Token(Token = "0x1700025C")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001747")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF08DC", Offset = "0x1AF08DC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x000180B6 File Offset: 0x000162B6
		[global::System.Obsolete]
		[global::Cpp2ILInjected.Token(Token = "0x6001748")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF08E0", Offset = "0x1AF08E0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x000180B9 File Offset: 0x000162B9
		[global::System.Obsolete]
		[global::Cpp2ILInjected.Token(Token = "0x6001749")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0998", Offset = "0x1AF0998", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0400093B RID: 2363
		[global::Cpp2ILInjected.Token(Token = "0x4000BE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _locked;

		// Token: 0x0400093C RID: 2364
		[global::Cpp2ILInjected.Token(Token = "0x4000BE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Collections.ArrayList hostEvidenceList;

		// Token: 0x0400093D RID: 2365
		[global::Cpp2ILInjected.Token(Token = "0x4000BE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Collections.ArrayList assemblyEvidenceList;

		// Token: 0x020005E2 RID: 1506
		[global::Cpp2ILInjected.Token(Token = "0x20002A8")]
		private class EvidenceEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x060040E2 RID: 16610 RVA: 0x0001FD54 File Offset: 0x0001DF54
			[global::Cpp2ILInjected.Token(Token = "0x600174A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0A40", Offset = "0x1AF0A40", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public EvidenceEnumerator(global::System.Collections.IEnumerator hostenum, global::System.Collections.IEnumerator assemblyenum)
			{
				throw null;
			}

			// Token: 0x060040E3 RID: 16611 RVA: 0x0001FD57 File Offset: 0x0001DF57
			[global::Cpp2ILInjected.Token(Token = "0x600174B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0A70", Offset = "0x1AF0A70", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060040E4 RID: 16612 RVA: 0x0001FD5A File Offset: 0x0001DF5A
			[global::Cpp2ILInjected.Token(Token = "0x600174C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0B98", Offset = "0x1AF0B98", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x060040E5 RID: 16613 RVA: 0x0001FD5D File Offset: 0x0001DF5D
			[global::Cpp2ILInjected.Token(Token = "0x1700025D")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600174D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AF0CB8", Offset = "0x1AF0CB8", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400192D RID: 6445
			[global::Cpp2ILInjected.Token(Token = "0x4000BE3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.Collections.IEnumerator currentEnum;

			// Token: 0x0400192E RID: 6446
			[global::Cpp2ILInjected.Token(Token = "0x4000BE4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private global::System.Collections.IEnumerator hostEnum;

			// Token: 0x0400192F RID: 6447
			[global::Cpp2ILInjected.Token(Token = "0x4000BE5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private global::System.Collections.IEnumerator assemblyEnum;
		}
	}
}
