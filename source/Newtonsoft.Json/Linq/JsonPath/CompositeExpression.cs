using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000AC RID: 172
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000F0")]
	internal class CompositeExpression : QueryExpression
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00003A0D File Offset: 0x00001C0D
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00003A10 File Offset: 0x00001C10
		[global::Cpp2ILInjected.Token(Token = "0x170001C2")]
		public List<QueryExpression> Expressions
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D23314", Offset = "0x1D23314", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2331C", Offset = "0x1D2331C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00003A13 File Offset: 0x00001C13
		[global::Cpp2ILInjected.Token(Token = "0x60009DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D22EBC", Offset = "0x1D22EBC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public CompositeExpression()
		{
			throw null;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00003A16 File Offset: 0x00001C16
		[global::Cpp2ILInjected.Token(Token = "0x60009DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D23324", Offset = "0x1D23324", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override bool IsMatch(JToken t)
		{
			throw null;
		}

		// Token: 0x040002D9 RID: 729
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<QueryExpression> <Expressions>k__BackingField;
	}
}
