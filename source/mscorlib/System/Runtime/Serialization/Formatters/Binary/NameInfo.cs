using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000380 RID: 896
	[global::Cpp2ILInjected.Token(Token = "0x200042A")]
	internal sealed class NameInfo
	{
		// Token: 0x06001EFC RID: 7932 RVA: 0x00019BFB File Offset: 0x00017DFB
		[global::Cpp2ILInjected.Token(Token = "0x600213D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B760", Offset = "0x1B6B760", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal NameInfo()
		{
			throw null;
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00019BFE File Offset: 0x00017DFE
		[global::Cpp2ILInjected.Token(Token = "0x600213E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B730", Offset = "0x1B6B730", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Init()
		{
			throw null;
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x00019C01 File Offset: 0x00017E01
		[global::Cpp2ILInjected.Token(Token = "0x17000453")]
		public bool IsSealed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600213F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B6B478", Offset = "0x1B6B478", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x00019C04 File Offset: 0x00017E04
		// (set) Token: 0x06001F00 RID: 7936 RVA: 0x00019C07 File Offset: 0x00017E07
		[global::Cpp2ILInjected.Token(Token = "0x17000454")]
		public string NIname
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002140")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B6F3FC", Offset = "0x1B6F3FC", Length = "0x30")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new object[]
			{
				typeof(NameInfo),
				typeof(NameInfo),
				typeof(WriteObjectInfo),
				typeof(NameInfo),
				typeof(int),
				typeof(int),
				typeof(global::System.Array)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteJaggedArray", MemberParameters = new object[]
			{
				typeof(NameInfo),
				typeof(NameInfo),
				typeof(WriteObjectInfo),
				typeof(NameInfo),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteRectangleArray", MemberParameters = new object[]
			{
				typeof(NameInfo),
				typeof(NameInfo),
				typeof(WriteObjectInfo),
				typeof(NameInfo),
				typeof(int),
				typeof(int[]),
				typeof(int[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002141")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B6F42C", Offset = "0x1B6F42C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000ECD RID: 3789
		[global::Cpp2ILInjected.Token(Token = "0x40011C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string NIFullName;

		// Token: 0x04000ECE RID: 3790
		[global::Cpp2ILInjected.Token(Token = "0x40011C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal long NIobjectId;

		// Token: 0x04000ECF RID: 3791
		[global::Cpp2ILInjected.Token(Token = "0x40011C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal long NIassemId;

		// Token: 0x04000ED0 RID: 3792
		[global::Cpp2ILInjected.Token(Token = "0x40011C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal InternalPrimitiveTypeE NIprimitiveTypeEnum;

		// Token: 0x04000ED1 RID: 3793
		[global::Cpp2ILInjected.Token(Token = "0x40011C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal global::System.Type NItype;

		// Token: 0x04000ED2 RID: 3794
		[global::Cpp2ILInjected.Token(Token = "0x40011C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal bool NIisSealed;

		// Token: 0x04000ED3 RID: 3795
		[global::Cpp2ILInjected.Token(Token = "0x40011C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		internal bool NIisArray;

		// Token: 0x04000ED4 RID: 3796
		[global::Cpp2ILInjected.Token(Token = "0x40011C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A")]
		internal bool NIisArrayItem;

		// Token: 0x04000ED5 RID: 3797
		[global::Cpp2ILInjected.Token(Token = "0x40011CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B")]
		internal bool NItransmitTypeOnObject;

		// Token: 0x04000ED6 RID: 3798
		[global::Cpp2ILInjected.Token(Token = "0x40011CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		internal bool NItransmitTypeOnMember;

		// Token: 0x04000ED7 RID: 3799
		[global::Cpp2ILInjected.Token(Token = "0x40011CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D")]
		internal bool NIisParentTypeOnObject;

		// Token: 0x04000ED8 RID: 3800
		[global::Cpp2ILInjected.Token(Token = "0x40011CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal InternalArrayTypeE NIarrayEnum;

		// Token: 0x04000ED9 RID: 3801
		[global::Cpp2ILInjected.Token(Token = "0x40011CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private bool NIsealedStatusChecked;
	}
}
