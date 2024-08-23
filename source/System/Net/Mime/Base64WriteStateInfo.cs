﻿using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Mime
{
	// Token: 0x02000234 RID: 564
	[global::Cpp2ILInjected.Token(Token = "0x2000325")]
	internal class Base64WriteStateInfo : WriteStateInfoBase
	{
		// Token: 0x060012A8 RID: 4776 RVA: 0x00006389 File Offset: 0x00004589
		[global::Cpp2ILInjected.Token(Token = "0x60014E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38FC0", Offset = "0x1E38FC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Base64WriteStateInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal Base64WriteStateInfo()
		{
			throw null;
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x0000638C File Offset: 0x0000458C
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x0000638F File Offset: 0x0000458F
		[global::Cpp2ILInjected.Token(Token = "0x170004C4")]
		internal int Padding
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E390C4", Offset = "0x1E390C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E390CC", Offset = "0x1E390CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00006392 File Offset: 0x00004592
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x00006395 File Offset: 0x00004595
		[global::Cpp2ILInjected.Token(Token = "0x170004C5")]
		internal byte LastBits
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E390D4", Offset = "0x1E390D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60014EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E390DC", Offset = "0x1E390DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000D5F RID: 3423
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400115C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int <Padding>k__BackingField;

		// Token: 0x04000D60 RID: 3424
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400115D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private byte <LastBits>k__BackingField;
	}
}