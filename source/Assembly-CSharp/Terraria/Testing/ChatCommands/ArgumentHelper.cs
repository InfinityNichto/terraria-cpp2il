using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Testing.ChatCommands
{
	// Token: 0x0200037D RID: 893
	[global::Cpp2ILInjected.Token(Token = "0x200050B")]
	public static class ArgumentHelper
	{
		// Token: 0x06002D02 RID: 11522 RVA: 0x0002A12B File Offset: 0x0002832B
		[global::Cpp2ILInjected.Token(Token = "0x6003137")]
		[global::Cpp2ILInjected.Address(RVA = "0x13037D4", Offset = "0x13037D4", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentListResult), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<string>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static ArgumentListResult ParseList(string arguments)
		{
			throw null;
		}

		// Token: 0x020008DE RID: 2270
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200050C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004BE0 RID: 19424 RVA: 0x0002F71D File Offset: 0x0002D91D
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003138")]
			[global::Cpp2ILInjected.Address(RVA = "0x1303A4C", Offset = "0x1303A4C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004BE1 RID: 19425 RVA: 0x0002F720 File Offset: 0x0002D920
			[global::Cpp2ILInjected.Token(Token = "0x6003139")]
			[global::Cpp2ILInjected.Address(RVA = "0x1303AA8", Offset = "0x1303AA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004BE2 RID: 19426 RVA: 0x0002F723 File Offset: 0x0002D923
			[global::Cpp2ILInjected.Token(Token = "0x600313A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1303AB0", Offset = "0x1303AB0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
			internal string <ParseList>b__0_0(string arg)
			{
				throw null;
			}

			// Token: 0x06004BE3 RID: 19427 RVA: 0x0002F726 File Offset: 0x0002D926
			[global::Cpp2ILInjected.Token(Token = "0x600313B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1303ABC", Offset = "0x1303ABC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <ParseList>b__0_1(string arg)
			{
				throw null;
			}

			// Token: 0x040080FC RID: 33020
			[global::Cpp2ILInjected.Token(Token = "0x4003AFD")]
			public static readonly ArgumentHelper.<>c <>9;

			// Token: 0x040080FD RID: 33021
			[global::Cpp2ILInjected.Token(Token = "0x4003AFE")]
			public static Func<string, string> <>9__0_0;

			// Token: 0x040080FE RID: 33022
			[global::Cpp2ILInjected.Token(Token = "0x4003AFF")]
			public static Func<string, bool> <>9__0_1;
		}
	}
}
