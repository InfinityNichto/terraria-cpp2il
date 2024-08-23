using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000CD RID: 205
	[global::Cpp2ILInjected.Token(Token = "0x20000FF")]
	[global::System.Serializable]
	public class OrdinalComparer : global::System.StringComparer
	{
		// Token: 0x060008E9 RID: 2281 RVA: 0x00015F23 File Offset: 0x00014123
		[global::Cpp2ILInjected.Token(Token = "0x6000991")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AFE4", Offset = "0x1C4AFE4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.StringComparer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalCaseSensitiveComparer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalIgnoreCaseComparer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal OrdinalComparer(bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00015F26 File Offset: 0x00014126
		[global::Cpp2ILInjected.Token(Token = "0x6000992")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B050", Offset = "0x1C4B050", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		public override int Compare(string x, string y)
		{
			throw null;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00015F29 File Offset: 0x00014129
		[global::Cpp2ILInjected.Token(Token = "0x6000993")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B0A8", Offset = "0x1C4B0A8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		public override bool Equals(string x, string y)
		{
			throw null;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00015F2C File Offset: 0x0001412C
		[global::Cpp2ILInjected.Token(Token = "0x6000994")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B128", Offset = "0x1C4B128", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int GetHashCode(string obj)
		{
			throw null;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00015F2F File Offset: 0x0001412F
		[global::Cpp2ILInjected.Token(Token = "0x6000995")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B1B0", Offset = "0x1C4B1B0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00015F32 File Offset: 0x00014132
		[global::Cpp2ILInjected.Token(Token = "0x6000996")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B23C", Offset = "0x1C4B23C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x04000256 RID: 598
		[global::Cpp2ILInjected.Token(Token = "0x40003A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool _ignoreCase;
	}
}
