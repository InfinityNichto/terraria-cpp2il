using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000330 RID: 816
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003D7")]
	public static class FormatterServices
	{
		// Token: 0x06001CC6 RID: 7366 RVA: 0x0001955F File Offset: 0x0001775F
		[global::Cpp2ILInjected.Token(Token = "0x6001F02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B521A8", Offset = "0x1B521A8", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(global::System.Reflection.Binder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		static FormatterServices()
		{
			throw null;
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00019562 File Offset: 0x00017762
		[global::Cpp2ILInjected.Token(Token = "0x6001F03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B52314", Offset = "0x1B52314", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static global::System.Reflection.MemberInfo[] GetSerializableMembers(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00019565 File Offset: 0x00017765
		[global::Cpp2ILInjected.Token(Token = "0x6001F04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B52468", Offset = "0x1B52468", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static bool CheckSerializable(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00019568 File Offset: 0x00017768
		[global::Cpp2ILInjected.Token(Token = "0x6001F05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B52478", Offset = "0x1B52478", Length = "0x660")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterServices.<>c__DisplayClass9_0), Member = "<GetSerializableMembers>b__0", MemberParameters = new object[] { typeof(MemberHolder) }, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetSerializableMembers", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetParentTypes", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(ref global::System.RuntimeType[]),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "get_IsNotSerialized", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationFieldInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.RuntimeFieldInfo),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		private static global::System.Reflection.MemberInfo[] InternalGetSerializableMembers(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0001956B File Offset: 0x0001776B
		[global::Cpp2ILInjected.Token(Token = "0x6001F06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B52AD8", Offset = "0x1B52AD8", Length = "0x3BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static bool GetParentTypes(global::System.RuntimeType parentType, out global::System.RuntimeType[] parentTypes, out int parentTypeCount)
		{
			throw null;
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0001956E File Offset: 0x0001776E
		[global::Cpp2ILInjected.Token(Token = "0x6001F07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B52F1C", Offset = "0x1B52F1C", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ReadObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public static global::System.Reflection.MemberInfo[] GetSerializableMembers(global::System.Type type, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00019571 File Offset: 0x00017771
		[global::Cpp2ILInjected.Token(Token = "0x6001F08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B53180", Offset = "0x1B53180", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new object[] { typeof(StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryMethodReturn), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonObjectContract", Member = "GetUninitializedObject", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "AllocateUninitializedClassInstance", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static object GetUninitializedObject(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00019574 File Offset: 0x00017774
		[global::Cpp2ILInjected.Token(Token = "0x6001F09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B53324", Offset = "0x1B53324", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "AllocateUninitializedClassInstance", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		private static object nativeGetUninitializedObject(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x00019577 File Offset: 0x00017777
		[global::Cpp2ILInjected.Token(Token = "0x6001F0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5332C", Offset = "0x1B5332C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool GetEnableUnsafeTypeForwarders()
		{
			throw null;
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0001957A File Offset: 0x0001777A
		[global::Cpp2ILInjected.Token(Token = "0x6001F0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B53334", Offset = "0x1B53334", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "CheckTypeForwardedFrom", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.SerObjectInfoCache),
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static bool UnsafeTypeForwardersIsEnabled()
		{
			throw null;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0001957D File Offset: 0x0001777D
		[global::Cpp2ILInjected.Token(Token = "0x6001F0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B533DC", Offset = "0x1B533DC", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterServices), Member = "PopulateObjectMembers", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.MemberInfo[]),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(ObjectHolder),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new object[]
		{
			typeof(ObjectHolder),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ValueFixup), Member = "Fixup", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static void SerializationSetValue(global::System.Reflection.MemberInfo fi, object target, object value)
		{
			throw null;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00019580 File Offset: 0x00017780
		[global::Cpp2ILInjected.Token(Token = "0x6001F0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B53650", Offset = "0x1B53650", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ReadObjectInfo), Member = "PopulateObjectMembers", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "SerializationSetValue", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public static object PopulateObjectMembers(object obj, global::System.Reflection.MemberInfo[] members, object[] data)
		{
			throw null;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00019583 File Offset: 0x00017783
		[global::Cpp2ILInjected.Token(Token = "0x6001F0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B538F8", Offset = "0x1B538F8", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationFieldInfo), Member = "InternalGetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public static object[] GetObjectData(object obj, global::System.Reflection.MemberInfo[] members)
		{
			throw null;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00019586 File Offset: 0x00017786
		[global::Cpp2ILInjected.Token(Token = "0x6001F0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B53C80", Offset = "0x1B53C80", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "FastBindToType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "GetSimplyNamedTypeFromAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "GetType", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryAssemblyInfo),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static global::System.Type GetTypeFromAssembly(global::System.Reflection.Assembly assem, string name)
		{
			throw null;
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00019589 File Offset: 0x00017789
		[global::Cpp2ILInjected.Token(Token = "0x6001F10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B53D10", Offset = "0x1B53D10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MemberInfoSerializationHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		internal static global::System.Reflection.Assembly LoadAssemblyFromString(string assemblyName)
		{
			throw null;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0001958C File Offset: 0x0001778C
		[global::Cpp2ILInjected.Token(Token = "0x6001F11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B53D18", Offset = "0x1B53D18", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryAssemblyInfo), Member = "GetAssembly", ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static global::System.Reflection.Assembly LoadAssemblyFromStringNoThrow(string assemblyName)
		{
			throw null;
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0001958F File Offset: 0x0001778F
		[global::Cpp2ILInjected.Token(Token = "0x6001F12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B53DEC", Offset = "0x1B53DEC", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterServices), Member = "GetClrTypeFullNameForNonArrayTypes", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = "GetTypeInformation", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Runtime.Serialization.Formatters.Binary.TypeInformation))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static string GetClrAssemblyName(global::System.Type type, out bool hasTypeForwardedFrom)
		{
			throw null;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00019592 File Offset: 0x00017792
		[global::Cpp2ILInjected.Token(Token = "0x6001F13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B53F40", Offset = "0x1B53F40", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterServices), Member = "GetClrTypeFullNameForArray", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterServices), Member = "GetClrTypeFullNameForNonArrayTypes", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter), Member = "GetTypeInformation", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Runtime.Serialization.Formatters.Binary.TypeInformation))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetClrTypeFullNameForNonArrayTypes", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string GetClrTypeFullName(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00019595 File Offset: 0x00017795
		[global::Cpp2ILInjected.Token(Token = "0x6001F14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B53FB8", Offset = "0x1B53FB8", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetClrTypeFullName", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static string GetClrTypeFullNameForArray(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00019598 File Offset: 0x00017798
		[global::Cpp2ILInjected.Token(Token = "0x6001F15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B541D0", Offset = "0x1B541D0", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FormatterServices), Member = "GetClrTypeFullName", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetClrTypeFullName", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetClrAssemblyName", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static string GetClrTypeFullNameForNonArrayTypes(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x04000C9D RID: 3229
		[global::Cpp2ILInjected.Token(Token = "0x4000F8E")]
		internal static global::System.Collections.Concurrent.ConcurrentDictionary<MemberHolder, global::System.Reflection.MemberInfo[]> m_MemberInfoTable;

		// Token: 0x04000C9E RID: 3230
		[global::Cpp2ILInjected.Token(Token = "0x4000F8F")]
		private static bool unsafeTypeForwardersIsEnabled;

		// Token: 0x04000C9F RID: 3231
		[global::Cpp2ILInjected.Token(Token = "0x4000F90")]
		private static bool unsafeTypeForwardersIsEnabledInitialized;

		// Token: 0x04000CA0 RID: 3232
		[global::Cpp2ILInjected.Token(Token = "0x4000F91")]
		private static readonly global::System.Type[] advancedTypes;

		// Token: 0x04000CA1 RID: 3233
		[global::Cpp2ILInjected.Token(Token = "0x4000F92")]
		private static global::System.Reflection.Binder s_binder;

		// Token: 0x020005F2 RID: 1522
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20003D8")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004113 RID: 16659 RVA: 0x0001FDDB File Offset: 0x0001DFDB
			[global::Cpp2ILInjected.Token(Token = "0x6001F16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B53178", Offset = "0x1B53178", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass9_0()
			{
				throw null;
			}

			// Token: 0x06004114 RID: 16660 RVA: 0x0001FDDE File Offset: 0x0001DFDE
			[global::Cpp2ILInjected.Token(Token = "0x6001F17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B5440C", Offset = "0x1B5440C", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal global::System.Reflection.MemberInfo[] <GetSerializableMembers>b__0(MemberHolder _)
			{
				throw null;
			}

			// Token: 0x04001979 RID: 6521
			[global::Cpp2ILInjected.Token(Token = "0x4000F93")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public global::System.Type type;
		}
	}
}
