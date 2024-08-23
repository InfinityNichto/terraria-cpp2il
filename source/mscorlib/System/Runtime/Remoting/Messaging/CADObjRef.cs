using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020002F7 RID: 759
	[global::Cpp2ILInjected.Token(Token = "0x200039C")]
	internal class CADObjRef
	{
		// Token: 0x06001B8C RID: 7052 RVA: 0x00019223 File Offset: 0x00017423
		[global::Cpp2ILInjected.Token(Token = "0x6001DBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44CE0", Offset = "0x1B44CE0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjRef), Member = "SerializeType", ReturnType = typeof(byte[]))]
		public CADObjRef(ObjRef o, int sourceDomain)
		{
			throw null;
		}

		// Token: 0x04000C19 RID: 3097
		[global::Cpp2ILInjected.Token(Token = "0x4000F05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ObjRef objref;

		// Token: 0x04000C1A RID: 3098
		[global::Cpp2ILInjected.Token(Token = "0x4000F06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int SourceDomain;

		// Token: 0x04000C1B RID: 3099
		[global::Cpp2ILInjected.Token(Token = "0x4000F07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal byte[] TypeInfo;
	}
}
