using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000370 RID: 880
	[global::Cpp2ILInjected.Token(Token = "0x2000418")]
	internal sealed class ObjectMapInfo
	{
		// Token: 0x06001E3E RID: 7742 RVA: 0x000199C1 File Offset: 0x00017BC1
		[global::Cpp2ILInjected.Token(Token = "0x600207C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B61724", Offset = "0x1B61724", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ObjectMapInfo(int objectId, int numMembers, string[] memberNames, global::System.Type[] memberTypes)
		{
			throw null;
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x000199C4 File Offset: 0x00017BC4
		[global::Cpp2ILInjected.Token(Token = "0x600207D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B61638", Offset = "0x1B61638", Length = "0xEC")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool isCompatible(int numMembers, string[] memberNames, global::System.Type[] memberTypes)
		{
			throw null;
		}

		// Token: 0x04000E16 RID: 3606
		[global::Cpp2ILInjected.Token(Token = "0x4001108")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int objectId;

		// Token: 0x04000E17 RID: 3607
		[global::Cpp2ILInjected.Token(Token = "0x4001109")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int numMembers;

		// Token: 0x04000E18 RID: 3608
		[global::Cpp2ILInjected.Token(Token = "0x400110A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string[] memberNames;

		// Token: 0x04000E19 RID: 3609
		[global::Cpp2ILInjected.Token(Token = "0x400110B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Type[] memberTypes;
	}
}
