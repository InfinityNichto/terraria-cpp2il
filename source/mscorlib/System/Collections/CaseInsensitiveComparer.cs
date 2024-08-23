using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x020004FB RID: 1275
	[global::Cpp2ILInjected.Token(Token = "0x20005F3")]
	[global::System.Serializable]
	public class CaseInsensitiveComparer : IComparer
	{
		// Token: 0x06002A7D RID: 10877 RVA: 0x0001BB3C File Offset: 0x00019D3C
		[global::Cpp2ILInjected.Token(Token = "0x6002DF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0866C", Offset = "0x1C0866C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CaseInsensitiveComparer()
		{
			throw null;
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x0001BB3F File Offset: 0x00019D3F
		[global::Cpp2ILInjected.Token(Token = "0x6002DF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C086E0", Offset = "0x1C086E0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaseInsensitiveComparer), Member = "get_Default", ReturnType = typeof(CaseInsensitiveComparer))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.CompatibleComparer", Member = "get_DefaultComparer", ReturnType = typeof(IComparer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CaseInsensitiveComparer(global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x0001BB42 File Offset: 0x00019D42
		[global::Cpp2ILInjected.Token(Token = "0x17000717")]
		public static CaseInsensitiveComparer Default
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08764", Offset = "0x1C08764", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetEnvironmentVariablesNoCase", ReturnType = typeof(Hashtable))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaseInsensitiveComparer), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x0001BB45 File Offset: 0x00019D45
		[global::Cpp2ILInjected.Token(Token = "0x6002DF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C087EC", Offset = "0x1C087EC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparer), Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int Compare(object a, object b)
		{
			throw null;
		}

		// Token: 0x040015B9 RID: 5561
		[global::Cpp2ILInjected.Token(Token = "0x40019B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Globalization.CompareInfo _compareInfo;
	}
}
