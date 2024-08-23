using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020002F9 RID: 761
	[global::Cpp2ILInjected.Token(Token = "0x200039E")]
	internal class CADMessageBase
	{
		// Token: 0x06001B90 RID: 7056 RVA: 0x0001922F File Offset: 0x0001742F
		[global::Cpp2ILInjected.Token(Token = "0x6001DC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B454E4", Offset = "0x1B454E4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodCallMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodReturnMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMethodRef), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "SerializeObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CADMessageBase(IMethodMessage msg)
		{
			throw null;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00019232 File Offset: 0x00017432
		[global::Cpp2ILInjected.Token(Token = "0x6001DC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4556C", Offset = "0x1B4556C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodReturnMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = ".ctor", MemberParameters = new object[] { typeof(CADMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "DeserializeObjectSafe", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.Reflection.MethodBase GetMethod()
		{
			throw null;
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00019235 File Offset: 0x00017435
		[global::Cpp2ILInjected.Token(Token = "0x6001DC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B455E8", Offset = "0x1B455E8", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodReturnMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected static global::System.Type[] GetSignature(global::System.Reflection.MethodBase methodBase, bool load)
		{
			throw null;
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00019238 File Offset: 0x00017438
		[global::Cpp2ILInjected.Token(Token = "0x6001DC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B45768", Offset = "0x1B45768", Length = "0x6F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodCallMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodReturnMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary), Member = "HasUserData", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageDictionary), Member = "get_InternalDictionary", ReturnType = typeof(global::System.Collections.IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		internal static int MarshalProperties(global::System.Collections.IDictionary dict, ref global::System.Collections.ArrayList args)
		{
			throw null;
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0001923B File Offset: 0x0001743B
		[global::Cpp2ILInjected.Token(Token = "0x6001DC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B45FE4", Offset = "0x1B45FE4", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = ".ctor", MemberParameters = new object[] { typeof(CADMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IMethodCallMessage),
			typeof(CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void UnmarshalProperties(global::System.Collections.IDictionary dict, int count, global::System.Collections.ArrayList args)
		{
			throw null;
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0001923E File Offset: 0x0001743E
		[global::Cpp2ILInjected.Token(Token = "0x6001DC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B46110", Offset = "0x1B46110", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMessageBase), Member = "MarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool IsPossibleToIgnoreMarshal(object obj)
		{
			throw null;
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00019241 File Offset: 0x00017441
		[global::Cpp2ILInjected.Token(Token = "0x6001DC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B462C0", Offset = "0x1B462C0", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMessageBase), Member = "MarshalArguments", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodReturnMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "IsPossibleToIgnoreMarshal", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "IsTransparentProxy", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "Marshal", MemberParameters = new object[] { typeof(global::System.MarshalByRefObject) }, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetDomainID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjRef), Member = "SerializeType", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected object MarshalArgument(object arg, ref global::System.Collections.ArrayList args)
		{
			throw null;
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00019244 File Offset: 0x00017444
		[global::Cpp2ILInjected.Token(Token = "0x6001DC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4648C", Offset = "0x1B4648C", Length = "0x70C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMessageBase), Member = "UnmarshalArguments", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodReturnMessage), Member = "GetReturnValue", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IMethodCallMessage),
			typeof(CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new object[] { typeof(ObjRef) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Copy", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 60)]
		protected object UnmarshalArgument(object arg, global::System.Collections.ArrayList args)
		{
			throw null;
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00019247 File Offset: 0x00017447
		[global::Cpp2ILInjected.Token(Token = "0x6001DCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B46B98", Offset = "0x1B46B98", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodCallMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodReturnMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "MarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal object[] MarshalArguments(object[] arguments, ref global::System.Collections.ArrayList args)
		{
			throw null;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0001924A File Offset: 0x0001744A
		[global::Cpp2ILInjected.Token(Token = "0x6001DCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B46C5C", Offset = "0x1B46C5C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodCallMessage), Member = "GetArgs", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodReturnMessage), Member = "GetArgs", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = ".ctor", MemberParameters = new object[] { typeof(CADMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IMethodCallMessage),
			typeof(CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal object[] UnmarshalArguments(object[] arguments, global::System.Collections.ArrayList args)
		{
			throw null;
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0001924D File Offset: 0x0001744D
		[global::Cpp2ILInjected.Token(Token = "0x6001DCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B46D20", Offset = "0x1B46D20", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodCallMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodReturnMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected void SaveLogicalCallContext(IMethodMessage msg, ref global::System.Collections.ArrayList serializeList)
		{
			throw null;
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00019250 File Offset: 0x00017450
		[global::Cpp2ILInjected.Token(Token = "0x6001DCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B46F44", Offset = "0x1B46F44", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = ".ctor", MemberParameters = new object[] { typeof(CADMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IMethodCallMessage),
			typeof(CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal LogicalCallContext GetLogicalCallContext(global::System.Collections.ArrayList args)
		{
			throw null;
		}

		// Token: 0x04000C21 RID: 3105
		[global::Cpp2ILInjected.Token(Token = "0x4000F0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected object[] _args;

		// Token: 0x04000C22 RID: 3106
		[global::Cpp2ILInjected.Token(Token = "0x4000F0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected byte[] _serializedArgs;

		// Token: 0x04000C23 RID: 3107
		[global::Cpp2ILInjected.Token(Token = "0x4000F0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected int _propertyCount;

		// Token: 0x04000C24 RID: 3108
		[global::Cpp2ILInjected.Token(Token = "0x4000F10")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected CADArgHolder _callContext;

		// Token: 0x04000C25 RID: 3109
		[global::Cpp2ILInjected.Token(Token = "0x4000F11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal byte[] serializedMethod;
	}
}
