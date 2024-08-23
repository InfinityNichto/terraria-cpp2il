using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x0200032C RID: 812
	[global::Cpp2ILInjected.Token(Token = "0x20003D2")]
	internal sealed class SerializationEvents
	{
		// Token: 0x06001CB2 RID: 7346 RVA: 0x00019523 File Offset: 0x00017723
		[global::Cpp2ILInjected.Token(Token = "0x6001EEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51480", Offset = "0x1B51480", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.Serialization.SerializationEventsCache.<>c", Member = "<GetSerializationEventsForType>b__1_0", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(SerializationEvents))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "GetMethodsWithAttribute", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal SerializationEvents(global::System.Type t)
		{
			throw null;
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00019526 File Offset: 0x00017726
		[global::Cpp2ILInjected.Token(Token = "0x6001EEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B515B4", Offset = "0x1B515B4", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationEvents), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "Reverse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private global::System.Collections.Generic.List<global::System.Reflection.MethodInfo> GetMethodsWithAttribute(global::System.Type attribute, global::System.Type t)
		{
			throw null;
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00019529 File Offset: 0x00017729
		[global::Cpp2ILInjected.Token(Token = "0x17000411")]
		internal bool HasOnSerializingEvents
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B517D4", Offset = "0x1B517D4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0001952C File Offset: 0x0001772C
		[global::Cpp2ILInjected.Token(Token = "0x6001EEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B517F4", Offset = "0x1B517F4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationObjectManager), Member = "RegisterObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationEventHandler),
			typeof(global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>)
		}, ReturnType = typeof(SerializationEventHandler))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InvokeOnSerializing(object obj, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0001952F File Offset: 0x0001772F
		[global::Cpp2ILInjected.Token(Token = "0x6001EEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51898", Offset = "0x1B51898", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RaiseOnDeserializingEvent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationEventHandler),
			typeof(global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>)
		}, ReturnType = typeof(SerializationEventHandler))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InvokeOnDeserializing(object obj, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00019532 File Offset: 0x00017732
		[global::Cpp2ILInjected.Token(Token = "0x6001EF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B518EC", Offset = "0x1B518EC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RaiseOnDeserializedEvent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSerializationManager), Member = "OnDeserialized", MemberParameters = new object[] { typeof(StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationEventHandler),
			typeof(global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>)
		}, ReturnType = typeof(SerializationEventHandler))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InvokeOnDeserialized(object obj, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00019535 File Offset: 0x00017735
		[global::Cpp2ILInjected.Token(Token = "0x6001EF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51940", Offset = "0x1B51940", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler)
		{
			throw null;
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00019538 File Offset: 0x00017738
		[global::Cpp2ILInjected.Token(Token = "0x6001EF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51B84", Offset = "0x1B51B84", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationEventHandler),
			typeof(global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>)
		}, ReturnType = typeof(SerializationEventHandler))]
		internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler)
		{
			throw null;
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0001953B File Offset: 0x0001773B
		[global::Cpp2ILInjected.Token(Token = "0x6001EF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51848", Offset = "0x1B51848", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationEventHandler),
			typeof(global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>)
		}, ReturnType = typeof(SerializationEventHandler))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static void InvokeOnDelegate(object obj, StreamingContext context, global::System.Collections.Generic.List<global::System.Reflection.MethodInfo> methods)
		{
			throw null;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0001953E File Offset: 0x0001773E
		[global::Cpp2ILInjected.Token(Token = "0x6001EF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B51954", Offset = "0x1B51954", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnSerializing", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnDeserializing", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnDeserialized", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationEvents), Member = "AddOnDeserialized", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationEventHandler)
		}, ReturnType = typeof(SerializationEventHandler))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnDelegate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext),
			typeof(global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationObjectManager), Member = "AddOnSerialized", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "AddOnDeserialized", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(global::System.Delegate)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, global::System.Collections.Generic.List<global::System.Reflection.MethodInfo> methods)
		{
			throw null;
		}

		// Token: 0x04000C92 RID: 3218
		[global::Cpp2ILInjected.Token(Token = "0x4000F81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Collections.Generic.List<global::System.Reflection.MethodInfo> _onSerializingMethods;

		// Token: 0x04000C93 RID: 3219
		[global::Cpp2ILInjected.Token(Token = "0x4000F82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly global::System.Collections.Generic.List<global::System.Reflection.MethodInfo> _onSerializedMethods;

		// Token: 0x04000C94 RID: 3220
		[global::Cpp2ILInjected.Token(Token = "0x4000F83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly global::System.Collections.Generic.List<global::System.Reflection.MethodInfo> _onDeserializingMethods;

		// Token: 0x04000C95 RID: 3221
		[global::Cpp2ILInjected.Token(Token = "0x4000F84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly global::System.Collections.Generic.List<global::System.Reflection.MethodInfo> _onDeserializedMethods;
	}
}
