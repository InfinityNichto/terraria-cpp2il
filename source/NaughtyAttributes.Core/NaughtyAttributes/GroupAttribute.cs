using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x0200001A RID: 26
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	public abstract class GroupAttribute : NaughtyAttribute
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002116 File Offset: 0x00000316
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002119 File Offset: 0x00000319
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000043")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB585C", Offset = "0x1CB585C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000044")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5864", Offset = "0x1CB5864", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000211F File Offset: 0x0000031F
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		public int GroupOrder
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000045")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB586C", Offset = "0x1CB586C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000046")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5874", Offset = "0x1CB5874", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002122 File Offset: 0x00000322
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002125 File Offset: 0x00000325
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		public string ParentGroup
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000047")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB587C", Offset = "0x1CB587C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000048")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5884", Offset = "0x1CB5884", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002128 File Offset: 0x00000328
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000212B File Offset: 0x0000032B
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public string DisplayChildGroupCondition
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000049")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB588C", Offset = "0x1CB588C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600004A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5894", Offset = "0x1CB5894", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000212E File Offset: 0x0000032E
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5818", Offset = "0x1CB5818", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public GroupAttribute(string name, int groupOrder = -1, string parentGroup = null, string displayChildGroupCondition = null)
		{
			throw null;
		}

		// Token: 0x04000021 RID: 33
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Name>k__BackingField;

		// Token: 0x04000022 RID: 34
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int <GroupOrder>k__BackingField;

		// Token: 0x04000023 RID: 35
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string <ParentGroup>k__BackingField;

		// Token: 0x04000024 RID: 36
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string <DisplayChildGroupCondition>k__BackingField;
	}
}
