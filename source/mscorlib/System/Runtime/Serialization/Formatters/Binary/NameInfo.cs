using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200042A")]
	internal sealed class NameInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x600213D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B760", Offset = "0x1B6B760", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal NameInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600213E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B730", Offset = "0x1B6B730", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Init()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40011C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string NIFullName;

		[global::Cpp2ILInjected.Token(Token = "0x40011C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal long NIobjectId;

		[global::Cpp2ILInjected.Token(Token = "0x40011C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal long NIassemId;

		[global::Cpp2ILInjected.Token(Token = "0x40011C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal InternalPrimitiveTypeE NIprimitiveTypeEnum;

		[global::Cpp2ILInjected.Token(Token = "0x40011C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal global::System.Type NItype;

		[global::Cpp2ILInjected.Token(Token = "0x40011C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal bool NIisSealed;

		[global::Cpp2ILInjected.Token(Token = "0x40011C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		internal bool NIisArray;

		[global::Cpp2ILInjected.Token(Token = "0x40011C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A")]
		internal bool NIisArrayItem;

		[global::Cpp2ILInjected.Token(Token = "0x40011CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B")]
		internal bool NItransmitTypeOnObject;

		[global::Cpp2ILInjected.Token(Token = "0x40011CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		internal bool NItransmitTypeOnMember;

		[global::Cpp2ILInjected.Token(Token = "0x40011CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D")]
		internal bool NIisParentTypeOnObject;

		[global::Cpp2ILInjected.Token(Token = "0x40011CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal InternalArrayTypeE NIarrayEnum;

		[global::Cpp2ILInjected.Token(Token = "0x40011CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private bool NIsealedStatusChecked;
	}
}
