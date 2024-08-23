using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000481 RID: 1153
	[global::Cpp2ILInjected.Token(Token = "0x200054C")]
	public class EnumerationOptions
	{
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x0001AD68 File Offset: 0x00018F68
		[global::Cpp2ILInjected.Token(Token = "0x170005C6")]
		internal static EnumerationOptions Compatible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002849")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA1F54", Offset = "0x1BA1F54", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x0001AD6B File Offset: 0x00018F6B
		[global::Cpp2ILInjected.Token(Token = "0x170005C7")]
		private static EnumerationOptions CompatibleRecursive
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600284A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA1FAC", Offset = "0x1BA1FAC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x0001AD6E File Offset: 0x00018F6E
		[global::Cpp2ILInjected.Token(Token = "0x170005C8")]
		internal static EnumerationOptions Default
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600284B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA2004", Offset = "0x1BA2004", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x0001AD71 File Offset: 0x00018F71
		[global::Cpp2ILInjected.Token(Token = "0x600284C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA205C", Offset = "0x1BA205C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EnumerationOptions()
		{
			throw null;
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x0001AD74 File Offset: 0x00018F74
		[global::Cpp2ILInjected.Token(Token = "0x600284D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA159C", Offset = "0x1BA159C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(SearchOption)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static EnumerationOptions FromSearchOption(SearchOption searchOption)
		{
			throw null;
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x0001AD77 File Offset: 0x00018F77
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x0001AD7A File Offset: 0x00018F7A
		[global::Cpp2ILInjected.Token(Token = "0x170005C9")]
		public bool RecurseSubdirectories
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600284E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA2084", Offset = "0x1BA2084", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600284F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA208C", Offset = "0x1BA208C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x0001AD7D File Offset: 0x00018F7D
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x0001AD80 File Offset: 0x00018F80
		[global::Cpp2ILInjected.Token(Token = "0x170005CA")]
		public bool IgnoreInaccessible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002850")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA2098", Offset = "0x1BA2098", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002851")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA20A0", Offset = "0x1BA20A0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x0001AD83 File Offset: 0x00018F83
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x0001AD86 File Offset: 0x00018F86
		[global::Cpp2ILInjected.Token(Token = "0x170005CB")]
		public FileAttributes AttributesToSkip
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002852")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA20AC", Offset = "0x1BA20AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002853")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA20B4", Offset = "0x1BA20B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x0001AD89 File Offset: 0x00018F89
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x0001AD8C File Offset: 0x00018F8C
		[global::Cpp2ILInjected.Token(Token = "0x170005CC")]
		public MatchType MatchType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002854")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA20BC", Offset = "0x1BA20BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002855")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA20C4", Offset = "0x1BA20C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x0001AD8F File Offset: 0x00018F8F
		[global::Cpp2ILInjected.Token(Token = "0x170005CD")]
		public MatchCasing MatchCasing
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002856")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA20CC", Offset = "0x1BA20CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x0001AD92 File Offset: 0x00018F92
		[global::Cpp2ILInjected.Token(Token = "0x170005CE")]
		public bool ReturnSpecialDirectories
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002857")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA20D4", Offset = "0x1BA20D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x0001AD95 File Offset: 0x00018F95
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002858")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA20DC", Offset = "0x1BA20DC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static EnumerationOptions()
		{
			throw null;
		}

		// Token: 0x0400129F RID: 4767
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40015C1")]
		private static readonly EnumerationOptions <Compatible>k__BackingField;

		// Token: 0x040012A0 RID: 4768
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40015C2")]
		private static readonly EnumerationOptions <CompatibleRecursive>k__BackingField;

		// Token: 0x040012A1 RID: 4769
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40015C3")]
		private static readonly EnumerationOptions <Default>k__BackingField;

		// Token: 0x040012A2 RID: 4770
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40015C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <RecurseSubdirectories>k__BackingField;

		// Token: 0x040012A3 RID: 4771
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40015C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool <IgnoreInaccessible>k__BackingField;

		// Token: 0x040012A4 RID: 4772
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40015C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private FileAttributes <AttributesToSkip>k__BackingField;

		// Token: 0x040012A5 RID: 4773
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40015C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private MatchType <MatchType>k__BackingField;

		// Token: 0x040012A6 RID: 4774
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40015C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private MatchCasing <MatchCasing>k__BackingField;

		// Token: 0x040012A7 RID: 4775
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40015C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool <ReturnSpecialDirectories>k__BackingField;
	}
}
