using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000364 RID: 868
	[global::Cpp2ILInjected.Token(Token = "0x200040C")]
	internal sealed class BinaryObjectWithMap
	{
		// Token: 0x06001DC3 RID: 7619 RVA: 0x00019850 File Offset: 0x00017A50
		[global::Cpp2ILInjected.Token(Token = "0x6002001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D68C", Offset = "0x1B5D68C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryObjectWithMap()
		{
			throw null;
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00019853 File Offset: 0x00017A53
		[global::Cpp2ILInjected.Token(Token = "0x6002002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D694", Offset = "0x1B5D694", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00019856 File Offset: 0x00017A56
		[global::Cpp2ILInjected.Token(Token = "0x6002003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D6BC", Offset = "0x1B5D6BC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId)
		{
			throw null;
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00019859 File Offset: 0x00017A59
		[global::Cpp2ILInjected.Token(Token = "0x6002004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D6E0", Offset = "0x1B5D6E0", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(WriteObjectInfo[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x0001985C File Offset: 0x00017A5C
		[global::Cpp2ILInjected.Token(Token = "0x6002005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D7C0", Offset = "0x1B5D7C0", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0001985F File Offset: 0x00017A5F
		[global::Cpp2ILInjected.Token(Token = "0x6002006")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D8D0", Offset = "0x1B5D8D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000D8F RID: 3471
		[global::Cpp2ILInjected.Token(Token = "0x4001081")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04000D90 RID: 3472
		[global::Cpp2ILInjected.Token(Token = "0x4001082")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int objectId;

		// Token: 0x04000D91 RID: 3473
		[global::Cpp2ILInjected.Token(Token = "0x4001083")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string name;

		// Token: 0x04000D92 RID: 3474
		[global::Cpp2ILInjected.Token(Token = "0x4001084")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int numMembers;

		// Token: 0x04000D93 RID: 3475
		[global::Cpp2ILInjected.Token(Token = "0x4001085")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string[] memberNames;

		// Token: 0x04000D94 RID: 3476
		[global::Cpp2ILInjected.Token(Token = "0x4001086")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal int assemId;
	}
}
