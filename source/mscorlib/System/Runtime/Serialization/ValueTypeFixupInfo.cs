using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x0200032F RID: 815
	[global::Cpp2ILInjected.Token(Token = "0x20003D6")]
	internal sealed class ValueTypeFixupInfo
	{
		// Token: 0x06001CC2 RID: 7362 RVA: 0x00019553 File Offset: 0x00017753
		[global::Cpp2ILInjected.Token(Token = "0x6001EFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B52058", Offset = "0x1B52058", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[]),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public ValueTypeFixupInfo(long containerID, global::System.Reflection.FieldInfo member, int[] parentIndex)
		{
			throw null;
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00019556 File Offset: 0x00017756
		[global::Cpp2ILInjected.Token(Token = "0x17000412")]
		public long ContainerID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B52190", Offset = "0x1B52190", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00019559 File Offset: 0x00017759
		[global::Cpp2ILInjected.Token(Token = "0x17000413")]
		public global::System.Reflection.FieldInfo ParentField
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F00")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B52198", Offset = "0x1B52198", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x0001955C File Offset: 0x0001775C
		[global::Cpp2ILInjected.Token(Token = "0x17000414")]
		public int[] ParentIndex
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B521A0", Offset = "0x1B521A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000C9A RID: 3226
		[global::Cpp2ILInjected.Token(Token = "0x4000F8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly long _containerID;

		// Token: 0x04000C9B RID: 3227
		[global::Cpp2ILInjected.Token(Token = "0x4000F8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly global::System.Reflection.FieldInfo _parentField;

		// Token: 0x04000C9C RID: 3228
		[global::Cpp2ILInjected.Token(Token = "0x4000F8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly int[] _parentIndex;
	}
}
