using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x0200032D RID: 813
	[global::Cpp2ILInjected.Token(Token = "0x20003D3")]
	internal static class SerializationEventsCache
	{
		// Token: 0x06001CBC RID: 7356 RVA: 0x00019541 File Offset: 0x00017741
		[global::Cpp2ILInjected.Token(Token = "0x6001EF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51B98", Offset = "0x1B51B98", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationObjectManager), Member = "RegisterObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationObjectManager), Member = "AddOnSerialized", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "AddOnDeserialized", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RaiseOnDeserializedEvent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RaiseOnDeserializingEvent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSerializationManager), Member = "OnDeserialized", MemberParameters = new object[] { typeof(StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<object, object>), Member = "GetOrAdd", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Func<object, object>)
		}, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static SerializationEvents GetSerializationEventsForType(global::System.Type t)
		{
			throw null;
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00019544 File Offset: 0x00017744
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001EF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51CC8", Offset = "0x1B51CC8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static SerializationEventsCache()
		{
			throw null;
		}

		// Token: 0x04000C96 RID: 3222
		[global::Cpp2ILInjected.Token(Token = "0x4000F85")]
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, SerializationEvents> s_cache;

		// Token: 0x020005F1 RID: 1521
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20003D4")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06004110 RID: 16656 RVA: 0x0001FDD2 File Offset: 0x0001DFD2
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001EF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B51D54", Offset = "0x1B51D54", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004111 RID: 16657 RVA: 0x0001FDD5 File Offset: 0x0001DFD5
			[global::Cpp2ILInjected.Token(Token = "0x6001EF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B51DB0", Offset = "0x1B51DB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004112 RID: 16658 RVA: 0x0001FDD8 File Offset: 0x0001DFD8
			[global::Cpp2ILInjected.Token(Token = "0x6001EF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B51DB8", Offset = "0x1B51DB8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal SerializationEvents <GetSerializationEventsForType>b__1_0(global::System.Type type)
			{
				throw null;
			}

			// Token: 0x04001977 RID: 6519
			[global::Cpp2ILInjected.Token(Token = "0x4000F86")]
			public static readonly SerializationEventsCache.<>c <>9;

			// Token: 0x04001978 RID: 6520
			[global::Cpp2ILInjected.Token(Token = "0x4000F87")]
			public static global::System.Func<global::System.Type, SerializationEvents> <>9__1_0;
		}
	}
}
