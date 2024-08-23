using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000331 RID: 817
	[global::Cpp2ILInjected.Token(Token = "0x20003D9")]
	internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate
	{
		// Token: 0x06001CDA RID: 7386 RVA: 0x0001959B File Offset: 0x0001779B
		[global::Cpp2ILInjected.Token(Token = "0x6001F18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B544B8", Offset = "0x1B544B8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0001959E File Offset: 0x0001779E
		[global::Cpp2ILInjected.Token(Token = "0x6001F19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54580", Offset = "0x1B54580", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			throw null;
		}

		// Token: 0x04000CA2 RID: 3234
		[global::Cpp2ILInjected.Token(Token = "0x4000F94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ISerializationSurrogate innerSurrogate;
	}
}
