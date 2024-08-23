using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000438 RID: 1080
	[global::Cpp2ILInjected.Token(Token = "0x20004F7")]
	public abstract class TypeInfo : global::System.Type
	{
		// Token: 0x06002240 RID: 8768 RVA: 0x0001A471 File Offset: 0x00018671
		[global::Cpp2ILInjected.Token(Token = "0x60024DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86A24", Offset = "0x1B86A24", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected TypeInfo()
		{
			throw null;
		}

		// Token: 0x04001124 RID: 4388
		[global::Cpp2ILInjected.Token(Token = "0x400143E")]
		private const BindingFlags DeclaredOnlyLookup = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
	}
}
