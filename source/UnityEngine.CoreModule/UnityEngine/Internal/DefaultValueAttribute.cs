using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Internal
{
	// Token: 0x020000E3 RID: 227
	[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	[global::Cpp2ILInjected.Token(Token = "0x2000103")]
	[Serializable]
	public class DefaultValueAttribute : Attribute
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x00002B54 File Offset: 0x00000D54
		[global::Cpp2ILInjected.Token(Token = "0x6000552")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89F74", Offset = "0x1F89F74", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultValueAttribute(string value)
		{
			throw null;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00002B57 File Offset: 0x00000D57
		[global::Cpp2ILInjected.Token(Token = "0x17000116")]
		public object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000553")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F89F9C", Offset = "0x1F89F9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002B5A File Offset: 0x00000D5A
		[global::Cpp2ILInjected.Token(Token = "0x6000554")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89FA4", Offset = "0x1F89FA4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002B5D File Offset: 0x00000D5D
		[global::Cpp2ILInjected.Token(Token = "0x6000555")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A048", Offset = "0x1F8A048", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x040003E7 RID: 999
		[global::Cpp2ILInjected.Token(Token = "0x400042D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object DefaultValue;
	}
}
