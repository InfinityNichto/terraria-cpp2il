using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000421 RID: 1057
	[global::Cpp2ILInjected.Token(Token = "0x20004E0")]
	public sealed class Missing : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06002158 RID: 8536 RVA: 0x0001A228 File Offset: 0x00018428
		[global::Cpp2ILInjected.Token(Token = "0x60023F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B830D4", Offset = "0x1B830D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private Missing()
		{
			throw null;
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0001A22B File Offset: 0x0001842B
		[global::Cpp2ILInjected.Token(Token = "0x60023F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B830DC", Offset = "0x1B830DC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0001A22E File Offset: 0x0001842E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60023F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83114", Offset = "0x1B83114", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static Missing()
		{
			throw null;
		}

		// Token: 0x040010CE RID: 4302
		[global::Cpp2ILInjected.Token(Token = "0x40013E8")]
		public static readonly Missing Value;
	}
}
