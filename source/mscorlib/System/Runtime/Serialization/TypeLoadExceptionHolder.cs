using System;
using System.Runtime.Serialization.Formatters.Binary;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x0200033B RID: 827
	[global::Cpp2ILInjected.Token(Token = "0x20003E3")]
	internal class TypeLoadExceptionHolder
	{
		// Token: 0x06001D41 RID: 7489 RVA: 0x000196CD File Offset: 0x000178CD
		[global::Cpp2ILInjected.Token(Token = "0x6001F7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58A00", Offset = "0x1B58A00", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal TypeLoadExceptionHolder(string typeName)
		{
			throw null;
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x000196D0 File Offset: 0x000178D0
		[global::Cpp2ILInjected.Token(Token = "0x17000431")]
		internal string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F80")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B58A28", Offset = "0x1B58A28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000CCD RID: 3277
		[global::Cpp2ILInjected.Token(Token = "0x4000FBF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_typeName;
	}
}
