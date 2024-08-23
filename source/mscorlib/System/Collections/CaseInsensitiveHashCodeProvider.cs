using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x020004FC RID: 1276
	[global::System.Obsolete("Please use StringComparer instead.")]
	[global::Cpp2ILInjected.Token(Token = "0x20005F4")]
	[global::System.Serializable]
	public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
	{
		// Token: 0x06002A81 RID: 10881 RVA: 0x0001BB48 File Offset: 0x00019D48
		[global::Cpp2ILInjected.Token(Token = "0x6002DF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C088CC", Offset = "0x1C088CC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaseInsensitiveHashCodeProvider), Member = "get_Default", ReturnType = typeof(CaseInsensitiveHashCodeProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CaseInsensitiveHashCodeProvider()
		{
			throw null;
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x0001BB4B File Offset: 0x00019D4B
		[global::Cpp2ILInjected.Token(Token = "0x6002DF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C08940", Offset = "0x1C08940", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.CompatibleComparer", Member = "get_DefaultHashCodeProvider", ReturnType = typeof(IHashCodeProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CaseInsensitiveHashCodeProvider(global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x0001BB4E File Offset: 0x00019D4E
		[global::Cpp2ILInjected.Token(Token = "0x17000718")]
		public static CaseInsensitiveHashCodeProvider Default
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C089C4", Offset = "0x1C089C4", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetEnvironmentVariablesNoCase", ReturnType = typeof(Hashtable))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaseInsensitiveHashCodeProvider), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x0001BB51 File Offset: 0x00019D51
		[global::Cpp2ILInjected.Token(Token = "0x6002DFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C08A14", Offset = "0x1C08A14", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public int GetHashCode(object obj)
		{
			throw null;
		}

		// Token: 0x040015BA RID: 5562
		[global::Cpp2ILInjected.Token(Token = "0x40019B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Globalization.CompareInfo _compareInfo;
	}
}
