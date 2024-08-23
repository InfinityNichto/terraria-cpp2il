using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000014 RID: 20
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000014")]
	public class ShowAssetPreviewAttribute : DrawerAttribute
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000020E9 File Offset: 0x000002E9
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000020EC File Offset: 0x000002EC
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		public int Width
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000034")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB56F8", Offset = "0x1CB56F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000035")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5700", Offset = "0x1CB5700", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000020EF File Offset: 0x000002EF
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000020F2 File Offset: 0x000002F2
		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		public int Height
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000036")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5708", Offset = "0x1CB5708", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000037")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5710", Offset = "0x1CB5710", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000020F5 File Offset: 0x000002F5
		[global::Cpp2ILInjected.Token(Token = "0x6000038")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5718", Offset = "0x1CB5718", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ShowAssetPreviewAttribute(int width = 64, int height = 64)
		{
			throw null;
		}

		// Token: 0x0400001D RID: 29
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <Width>k__BackingField;

		// Token: 0x0400001E RID: 30
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int <Height>k__BackingField;
	}
}
