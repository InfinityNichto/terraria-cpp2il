using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000EF")]
	internal abstract class QueryExpression
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001C1")]
		public QueryOperator Operator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D232FC", Offset = "0x1D232FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D23304", Offset = "0x1D23304", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009D6")]
		public abstract bool IsMatch(JToken t);

		[global::Cpp2ILInjected.Token(Token = "0x60009D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2330C", Offset = "0x1D2330C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected QueryExpression()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private QueryOperator <Operator>k__BackingField;
	}
}
