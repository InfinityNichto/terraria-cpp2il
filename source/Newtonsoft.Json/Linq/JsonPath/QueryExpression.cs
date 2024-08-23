using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000AB RID: 171
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000EF")]
	internal abstract class QueryExpression
	{
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00003A04 File Offset: 0x00001C04
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00003A07 File Offset: 0x00001C07
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

		// Token: 0x060008B4 RID: 2228
		[global::Cpp2ILInjected.Token(Token = "0x60009D6")]
		public abstract bool IsMatch(JToken t);

		// Token: 0x060008B5 RID: 2229 RVA: 0x00003A0A File Offset: 0x00001C0A
		[global::Cpp2ILInjected.Token(Token = "0x60009D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2330C", Offset = "0x1D2330C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected QueryExpression()
		{
			throw null;
		}

		// Token: 0x040002D8 RID: 728
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private QueryOperator <Operator>k__BackingField;
	}
}
