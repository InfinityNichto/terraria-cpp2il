using System;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000112 RID: 274
	[global::Cpp2ILInjected.Token(Token = "0x200014D")]
	[global::System.Serializable]
	internal sealed class Empty : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000C49 RID: 3145 RVA: 0x000168A7 File Offset: 0x00014AA7
		[global::Cpp2ILInjected.Token(Token = "0x6000D1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C650F8", Offset = "0x1C650F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private Empty()
		{
			throw null;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x000168AA File Offset: 0x00014AAA
		[global::Cpp2ILInjected.Token(Token = "0x6000D1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65100", Offset = "0x1C65100", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000168AD File Offset: 0x00014AAD
		[global::Cpp2ILInjected.Token(Token = "0x6000D1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C65148", Offset = "0x1C65148", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(int),
			typeof(string),
			typeof(global::System.Reflection.RuntimeAssembly)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000168B0 File Offset: 0x00014AB0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000D1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C651B0", Offset = "0x1C651B0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static Empty()
		{
			throw null;
		}

		// Token: 0x04000397 RID: 919
		[global::Cpp2ILInjected.Token(Token = "0x400050D")]
		public static readonly global::System.Empty Value;
	}
}
