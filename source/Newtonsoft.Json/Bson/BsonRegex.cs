using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020000E0 RID: 224
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000129")]
	internal class BsonRegex : BsonToken
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00003E3F File Offset: 0x0000203F
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00003E42 File Offset: 0x00002042
		[global::Cpp2ILInjected.Token(Token = "0x1700023A")]
		public BsonString Pattern
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A5CC", Offset = "0x1D3A5CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A5D4", Offset = "0x1D3A5D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00003E45 File Offset: 0x00002045
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00003E48 File Offset: 0x00002048
		[global::Cpp2ILInjected.Token(Token = "0x1700023B")]
		public BsonString Options
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B80")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A5DC", Offset = "0x1D3A5DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B81")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A5E4", Offset = "0x1D3A5E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00003E4B File Offset: 0x0000204B
		[global::Cpp2ILInjected.Token(Token = "0x6000B82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A5EC", Offset = "0x1D3A5EC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteRegex", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public BsonRegex(string pattern, string options)
		{
			throw null;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00003E4E File Offset: 0x0000204E
		[global::Cpp2ILInjected.Token(Token = "0x1700023C")]
		public override BsonType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B83")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A69C", Offset = "0x1D3A69C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400032E RID: 814
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000455")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private BsonString <Pattern>k__BackingField;

		// Token: 0x0400032F RID: 815
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000456")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private BsonString <Options>k__BackingField;
	}
}
