using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::Cpp2ILInjected.Token(Token = "0x200039C")]
	internal class CADObjRef
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001DBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44CE0", Offset = "0x1B44CE0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjRef), Member = "SerializeType", ReturnType = typeof(byte[]))]
		public CADObjRef(ObjRef o, int sourceDomain)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ObjRef objref;

		[global::Cpp2ILInjected.Token(Token = "0x4000F06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int SourceDomain;

		[global::Cpp2ILInjected.Token(Token = "0x4000F07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal byte[] TypeInfo;
	}
}
