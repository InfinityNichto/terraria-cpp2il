using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037F RID: 895
	[global::Cpp2ILInjected.Token(Token = "0x2000429")]
	internal sealed class InternalFE
	{
		// Token: 0x06001EFB RID: 7931 RVA: 0x00019BF8 File Offset: 0x00017DF8
		[global::Cpp2ILInjected.Token(Token = "0x600213C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6F3F4", Offset = "0x1B6F3F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public InternalFE()
		{
			throw null;
		}

		// Token: 0x04000EC9 RID: 3785
		[global::Cpp2ILInjected.Token(Token = "0x40011BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal FormatterTypeStyle FEtypeFormat;

		// Token: 0x04000ECA RID: 3786
		[global::Cpp2ILInjected.Token(Token = "0x40011BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal FormatterAssemblyStyle FEassemblyFormat;

		// Token: 0x04000ECB RID: 3787
		[global::Cpp2ILInjected.Token(Token = "0x40011C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal TypeFilterLevel FEsecurityLevel;

		// Token: 0x04000ECC RID: 3788
		[global::Cpp2ILInjected.Token(Token = "0x40011C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal InternalSerializerTypeE FEserializerTypeEnum;
	}
}
