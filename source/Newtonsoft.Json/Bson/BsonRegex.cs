using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000129")]
	internal class BsonRegex : BsonToken
	{
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

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000455")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private BsonString <Pattern>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000456")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private BsonString <Options>k__BackingField;
	}
}
