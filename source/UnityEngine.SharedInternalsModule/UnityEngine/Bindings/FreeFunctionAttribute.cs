using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	// Token: 0x02000016 RID: 22
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	internal class FreeFunctionAttribute : NativeMethodAttribute
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000020DD File Offset: 0x000002DD
		[global::Cpp2ILInjected.Token(Token = "0x6000030")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA411C", Offset = "0x1FA411C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public FreeFunctionAttribute()
		{
			throw null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020E0 File Offset: 0x000002E0
		[global::Cpp2ILInjected.Token(Token = "0x6000031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA413C", Offset = "0x1FA413C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public FreeFunctionAttribute(string name)
		{
			throw null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020E3 File Offset: 0x000002E3
		[global::Cpp2ILInjected.Token(Token = "0x6000032")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4158", Offset = "0x1FA4158", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public FreeFunctionAttribute(string name, bool isThreadSafe)
		{
			throw null;
		}
	}
}
