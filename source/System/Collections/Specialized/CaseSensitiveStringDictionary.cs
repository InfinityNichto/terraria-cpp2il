using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	// Token: 0x0200030A RID: 778
	[global::Cpp2ILInjected.Token(Token = "0x2000423")]
	internal class CaseSensitiveStringDictionary : StringDictionary
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x00007667 File Offset: 0x00005867
		[global::Cpp2ILInjected.Token(Token = "0x6001CAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E91230", Offset = "0x1E91230", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProcessStartInfo), Member = "get_EnvironmentVariables", ReturnType = typeof(StringDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringDictionary), Member = ".ctor", ReturnType = typeof(void))]
		public CaseSensitiveStringDictionary()
		{
			throw null;
		}

		// Token: 0x1700061C RID: 1564
		[global::Cpp2ILInjected.Token(Token = "0x1700066D")]
		public override string this[string key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E91234", Offset = "0x1E91234", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001CAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E912F4", Offset = "0x1E912F4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00007670 File Offset: 0x00005870
		[global::Cpp2ILInjected.Token(Token = "0x6001CAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9135C", Offset = "0x1E9135C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Add(string key, string value)
		{
			throw null;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00007673 File Offset: 0x00005873
		[global::Cpp2ILInjected.Token(Token = "0x6001CAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E913C4", Offset = "0x1E913C4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Remove(string key)
		{
			throw null;
		}
	}
}
