using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003D1")]
	[global::System.Serializable]
	public abstract class SerializationBinder
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001EE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5146C", Offset = "0x1B5146C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void BindToName(global::System.Type serializedType, out string assemblyName, out string typeName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001EE9")]
		public abstract global::System.Type BindToType(string assemblyName, string typeName);

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
