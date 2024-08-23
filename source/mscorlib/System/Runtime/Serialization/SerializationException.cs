using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000322 RID: 802
	[global::Cpp2ILInjected.Token(Token = "0x20003C8")]
	[global::System.Serializable]
	public class SerializationException : global::System.SystemException
	{
		// Token: 0x06001C8D RID: 7309 RVA: 0x000194CC File Offset: 0x000176CC
		[global::Cpp2ILInjected.Token(Token = "0x6001EC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50990", Offset = "0x1B50990", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SerializationException()
		{
			throw null;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x000194CF File Offset: 0x000176CF
		[global::Cpp2ILInjected.Token(Token = "0x6001EC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50A04", Offset = "0x1B50A04", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 84)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public SerializationException(string message)
		{
			throw null;
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x000194D2 File Offset: 0x000176D2
		[global::Cpp2ILInjected.Token(Token = "0x6001EC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50A28", Offset = "0x1B50A28", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "CompleteISerializableObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public SerializationException(string message, global::System.Exception innerException)
		{
			throw null;
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x000194D5 File Offset: 0x000176D5
		[global::Cpp2ILInjected.Token(Token = "0x6001EC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50A4C", Offset = "0x1B50A4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected SerializationException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x000194D8 File Offset: 0x000176D8
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001ECA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50A54", Offset = "0x1B50A54", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static SerializationException()
		{
			throw null;
		}

		// Token: 0x04000C86 RID: 3206
		[global::Cpp2ILInjected.Token(Token = "0x4000F75")]
		private static string s_nullMessage;
	}
}
