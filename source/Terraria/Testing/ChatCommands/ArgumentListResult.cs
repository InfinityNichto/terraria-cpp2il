using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Testing.ChatCommands
{
	// Token: 0x0200037E RID: 894
	[global::Cpp2ILInjected.Token(Token = "0x200050D")]
	public class ArgumentListResult : IEnumerable<string>, IEnumerable
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x0002A12E File Offset: 0x0002832E
		[global::Cpp2ILInjected.Token(Token = "0x17000625")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600313C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1303ACC", Offset = "0x1303ACC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005AB RID: 1451
		[global::Cpp2ILInjected.Token(Token = "0x17000626")]
		public string this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600313D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1303B0C", Offset = "0x1303B0C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x0002A134 File Offset: 0x00028334
		[global::Cpp2ILInjected.Token(Token = "0x600313E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13039DC", Offset = "0x13039DC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArgumentHelper), Member = "ParseList", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentListResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ArgumentListResult(IEnumerable<string> results)
		{
			throw null;
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x0002A137 File Offset: 0x00028337
		[global::Cpp2ILInjected.Token(Token = "0x600313F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303B64", Offset = "0x1303B64", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArgumentListResult), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private ArgumentListResult(bool isValid)
		{
			throw null;
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x0002A13A File Offset: 0x0002833A
		[global::Cpp2ILInjected.Token(Token = "0x6003140")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303BEC", Offset = "0x1303BEC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArgumentListResult), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEnumerator<string> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x0002A13D File Offset: 0x0002833D
		[global::Cpp2ILInjected.Token(Token = "0x6003141")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303C7C", Offset = "0x1303C7C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentListResult), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<string>))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x0002A140 File Offset: 0x00028340
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003142")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303C80", Offset = "0x1303C80", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentListResult), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ArgumentListResult()
		{
			throw null;
		}

		// Token: 0x040031A4 RID: 12708
		[global::Cpp2ILInjected.Token(Token = "0x4003B00")]
		public static readonly ArgumentListResult Empty;

		// Token: 0x040031A5 RID: 12709
		[global::Cpp2ILInjected.Token(Token = "0x4003B01")]
		public static readonly ArgumentListResult Invalid;

		// Token: 0x040031A6 RID: 12710
		[global::Cpp2ILInjected.Token(Token = "0x4003B02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly bool IsValid;

		// Token: 0x040031A7 RID: 12711
		[global::Cpp2ILInjected.Token(Token = "0x4003B03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly List<string> _results;
	}
}
