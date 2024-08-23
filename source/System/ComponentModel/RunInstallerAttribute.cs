using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002B8 RID: 696
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x20003B6")]
	public class RunInstallerAttribute : Attribute
	{
		// Token: 0x060016F5 RID: 5877 RVA: 0x00006EE7 File Offset: 0x000050E7
		[global::Cpp2ILInjected.Token(Token = "0x6001956")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D4BC", Offset = "0x1E5D4BC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RunInstallerAttribute(bool runInstaller)
		{
			throw null;
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00006EEA File Offset: 0x000050EA
		[global::Cpp2ILInjected.Token(Token = "0x170005CD")]
		public bool RunInstaller
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001957")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5D4E4", Offset = "0x1E5D4E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00006EED File Offset: 0x000050ED
		[global::Cpp2ILInjected.Token(Token = "0x6001958")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D4EC", Offset = "0x1E5D4EC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00006EF0 File Offset: 0x000050F0
		[global::Cpp2ILInjected.Token(Token = "0x6001959")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D594", Offset = "0x1E5D594", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00006EF3 File Offset: 0x000050F3
		[global::Cpp2ILInjected.Token(Token = "0x600195A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D59C", Offset = "0x1E5D59C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00006EF6 File Offset: 0x000050F6
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600195B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5D604", Offset = "0x1E5D604", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static RunInstallerAttribute()
		{
			throw null;
		}

		// Token: 0x04000EA6 RID: 3750
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <RunInstaller>k__BackingField;

		// Token: 0x04000EA7 RID: 3751
		[global::Cpp2ILInjected.Token(Token = "0x40012C5")]
		public static readonly RunInstallerAttribute Yes;

		// Token: 0x04000EA8 RID: 3752
		[global::Cpp2ILInjected.Token(Token = "0x40012C6")]
		public static readonly RunInstallerAttribute No;

		// Token: 0x04000EA9 RID: 3753
		[global::Cpp2ILInjected.Token(Token = "0x40012C7")]
		public static readonly RunInstallerAttribute Default;
	}
}
