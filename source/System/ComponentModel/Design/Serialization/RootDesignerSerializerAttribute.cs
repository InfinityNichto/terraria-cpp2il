using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel.Design.Serialization
{
	// Token: 0x02000302 RID: 770
	[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000415")]
	public sealed class RootDesignerSerializerAttribute : Attribute
	{
		// Token: 0x0600193E RID: 6462 RVA: 0x00007517 File Offset: 0x00005717
		[global::Cpp2ILInjected.Token(Token = "0x6001C1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8C724", Offset = "0x1E8C724", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
		{
			throw null;
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x0000751A File Offset: 0x0000571A
		[global::Cpp2ILInjected.Token(Token = "0x1700063E")]
		public string SerializerBaseTypeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001C1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8C760", Offset = "0x1E8C760", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x0000751D File Offset: 0x0000571D
		[global::Cpp2ILInjected.Token(Token = "0x1700063F")]
		public override object TypeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8C768", Offset = "0x1E8C768", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000F50 RID: 3920
		[global::Cpp2ILInjected.Token(Token = "0x4001391")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _typeId;

		// Token: 0x04000F51 RID: 3921
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001392")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly bool <Reloadable>k__BackingField;

		// Token: 0x04000F52 RID: 3922
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001393")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string <SerializerTypeName>k__BackingField;

		// Token: 0x04000F53 RID: 3923
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001394")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string <SerializerBaseTypeName>k__BackingField;
	}
}
