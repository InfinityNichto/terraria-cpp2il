using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037B RID: 891
	[global::Cpp2ILInjected.Token(Token = "0x2000425")]
	[global::System.Serializable]
	internal sealed class SizedArray : global::System.ICloneable
	{
		// Token: 0x06001EE7 RID: 7911 RVA: 0x00019BBC File Offset: 0x00017DBC
		[global::Cpp2ILInjected.Token(Token = "0x6002128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B96C", Offset = "0x1B6B96C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "get_ObjectMapIdTable", ReturnType = typeof(SizedArray))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal SizedArray()
		{
			throw null;
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00019BBF File Offset: 0x00017DBF
		[global::Cpp2ILInjected.Token(Token = "0x6002129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6BA3C", Offset = "0x1B6BA3C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "get_AssemIdToAssemblyTable", ReturnType = typeof(SizedArray))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal SizedArray(int length)
		{
			throw null;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00019BC2 File Offset: 0x00017DC2
		[global::Cpp2ILInjected.Token(Token = "0x600212A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6ED70", Offset = "0x1B6ED70", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SizedArray), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private SizedArray(SizedArray sizedArray)
		{
			throw null;
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00019BC5 File Offset: 0x00017DC5
		[global::Cpp2ILInjected.Token(Token = "0x600212B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6EE14", Offset = "0x1B6EE14", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SizedArray), Member = ".ctor", MemberParameters = new object[] { typeof(SizedArray) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x170003F3 RID: 1011
		[global::Cpp2ILInjected.Token(Token = "0x17000451")]
		internal object this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600212C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B6DCC8", Offset = "0x1B6DCC8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectMap), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string[]),
				typeof(BinaryTypeEnum[]),
				typeof(object[]),
				typeof(int[]),
				typeof(ObjectReader),
				typeof(int),
				typeof(BinaryAssemblyInfo),
				typeof(SizedArray)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600212D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B6DBFC", Offset = "0x1B6DBFC", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SizedArray), Member = "IncreaseCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00019BCE File Offset: 0x00017DCE
		[global::Cpp2ILInjected.Token(Token = "0x600212E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6EE6C", Offset = "0x1B6EE6C", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SizedArray), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal void IncreaseCapacity(int index)
		{
			throw null;
		}

		// Token: 0x04000EBB RID: 3771
		[global::Cpp2ILInjected.Token(Token = "0x40011B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal object[] objects;

		// Token: 0x04000EBC RID: 3772
		[global::Cpp2ILInjected.Token(Token = "0x40011B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object[] negObjects;
	}
}
