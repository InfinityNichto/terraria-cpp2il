using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000F8 RID: 248
	[global::Cpp2ILInjected.Token(Token = "0x200012A")]
	[global::System.Serializable]
	public readonly struct ConsoleKeyInfo
	{
		// Token: 0x06000AF1 RID: 2801 RVA: 0x000164C6 File Offset: 0x000146C6
		[global::Cpp2ILInjected.Token(Token = "0x6000B99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54DCC", Offset = "0x1C54DCC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.NullConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "CreateKeyInfoFromInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "CreateKeyMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WindowsConsoleDriver), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 64)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ConsoleKeyInfo(char keyChar, global::System.ConsoleKey key, bool shift, bool alt, bool control)
		{
			throw null;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000164C9 File Offset: 0x000146C9
		[global::Cpp2ILInjected.Token(Token = "0x17000102")]
		public char KeyChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C54E70", Offset = "0x1C54E70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000164CC File Offset: 0x000146CC
		[global::Cpp2ILInjected.Token(Token = "0x17000103")]
		public global::System.ConsoleKey Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C54E78", Offset = "0x1C54E78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x000164CF File Offset: 0x000146CF
		[global::Cpp2ILInjected.Token(Token = "0x6000B9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54E80", Offset = "0x1C54E80", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x000164D2 File Offset: 0x000146D2
		[global::Cpp2ILInjected.Token(Token = "0x6000B9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54F18", Offset = "0x1C54F18", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(global::System.ConsoleKeyInfo obj)
		{
			throw null;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000164D5 File Offset: 0x000146D5
		[global::Cpp2ILInjected.Token(Token = "0x6000B9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54F4C", Offset = "0x1C54F4C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0400036E RID: 878
		[global::Cpp2ILInjected.Token(Token = "0x40004C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly char _keyChar;

		// Token: 0x0400036F RID: 879
		[global::Cpp2ILInjected.Token(Token = "0x40004C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private readonly global::System.ConsoleKey _key;

		// Token: 0x04000370 RID: 880
		[global::Cpp2ILInjected.Token(Token = "0x40004C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly global::System.ConsoleModifiers _mods;
	}
}
