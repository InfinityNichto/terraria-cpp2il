using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x0200032B RID: 811
	[global::Cpp2ILInjected.Token(Token = "0x20003D1")]
	[global::System.Serializable]
	public abstract class SerializationBinder
	{
		// Token: 0x06001CAF RID: 7343 RVA: 0x0001951D File Offset: 0x0001771D
		[global::Cpp2ILInjected.Token(Token = "0x6001EE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5146C", Offset = "0x1B5146C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void BindToName(global::System.Type serializedType, out string assemblyName, out string typeName)
		{
			throw null;
		}

		// Token: 0x06001CB0 RID: 7344
		[global::Cpp2ILInjected.Token(Token = "0x6001EE9")]
		public abstract global::System.Type BindToType(string assemblyName, string typeName);

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00019520 File Offset: 0x00017720
		[global::Cpp2ILInjected.Token(Token = "0x6001EEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51478", Offset = "0x1B51478", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultSerializationBinder", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected SerializationBinder()
		{
			throw null;
		}
	}
}
