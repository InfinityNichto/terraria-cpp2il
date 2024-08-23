using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000273 RID: 627
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x2000369")]
	public sealed class DefaultPropertyAttribute : Attribute
	{
		// Token: 0x0600147B RID: 5243 RVA: 0x000068A2 File Offset: 0x00004AA2
		[global::Cpp2ILInjected.Token(Token = "0x60016C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48E00", Offset = "0x1E48E00", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultPropertyAttribute(string name)
		{
			throw null;
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x000068A5 File Offset: 0x00004AA5
		[global::Cpp2ILInjected.Token(Token = "0x1700052C")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E48E28", Offset = "0x1E48E28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x000068A8 File Offset: 0x00004AA8
		[global::Cpp2ILInjected.Token(Token = "0x60016C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48E30", Offset = "0x1E48E30", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000068AB File Offset: 0x00004AAB
		[global::Cpp2ILInjected.Token(Token = "0x60016C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48EA4", Offset = "0x1E48EA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x000068AE File Offset: 0x00004AAE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48EAC", Offset = "0x1E48EAC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static DefaultPropertyAttribute()
		{
			throw null;
		}

		// Token: 0x04000DF7 RID: 3575
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Name>k__BackingField;

		// Token: 0x04000DF8 RID: 3576
		[global::Cpp2ILInjected.Token(Token = "0x40011FD")]
		public static readonly DefaultPropertyAttribute Default;
	}
}
