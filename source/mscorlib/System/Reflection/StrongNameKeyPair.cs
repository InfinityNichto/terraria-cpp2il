using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000453 RID: 1107
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000518")]
	[global::System.Serializable]
	public class StrongNameKeyPair : global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x060023C3 RID: 9155 RVA: 0x0001A855 File Offset: 0x00018A55
		[global::Cpp2ILInjected.Token(Token = "0x6002667")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B93538", Offset = "0x1B93538", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		protected StrongNameKeyPair(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0001A858 File Offset: 0x00018A58
		[global::Cpp2ILInjected.Token(Token = "0x6002668")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9371C", Offset = "0x1B9371C", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0001A85B File Offset: 0x00018A5B
		[global::Cpp2ILInjected.Token(Token = "0x6002669")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B93864", Offset = "0x1B93864", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x040011F4 RID: 4596
		[global::Cpp2ILInjected.Token(Token = "0x4001512")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] _publicKey;

		// Token: 0x040011F5 RID: 4597
		[global::Cpp2ILInjected.Token(Token = "0x4001513")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _keyPairContainer;

		// Token: 0x040011F6 RID: 4598
		[global::Cpp2ILInjected.Token(Token = "0x4001514")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _keyPairExported;

		// Token: 0x040011F7 RID: 4599
		[global::Cpp2ILInjected.Token(Token = "0x4001515")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _keyPairArray;
	}
}
