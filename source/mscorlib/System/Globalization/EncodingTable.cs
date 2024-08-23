using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004CC RID: 1228
	[global::Cpp2ILInjected.Token(Token = "0x20005BB")]
	internal static class EncodingTable
	{
		// Token: 0x06002971 RID: 10609 RVA: 0x0001B8B1 File Offset: 0x00019AB1
		[global::Cpp2ILInjected.Token(Token = "0x6002CD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF766C", Offset = "0x1BF766C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingTable), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static int GetNumEncodingItems()
		{
			throw null;
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x0001B8B4 File Offset: 0x00019AB4
		[global::Cpp2ILInjected.Token(Token = "0x6002CD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF76C8", Offset = "0x1BF76C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static InternalEncodingDataItem ENC(string name, ushort cp)
		{
			throw null;
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x0001B8B7 File Offset: 0x00019AB7
		[global::Cpp2ILInjected.Token(Token = "0x6002CD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF76D0", Offset = "0x1BF76D0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags)
		{
			throw null;
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x0001B8BA File Offset: 0x00019ABA
		[global::Cpp2ILInjected.Token(Token = "0x6002CD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF76E4", Offset = "0x1BF76E4", Length = "0x42EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncodingTable), Member = "GetNumEncodingItems", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, int>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 437)]
		static EncodingTable()
		{
			throw null;
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x0001B8BD File Offset: 0x00019ABD
		[global::Cpp2ILInjected.Token(Token = "0x6002CD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFB9D0", Offset = "0x1BFB9D0", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingTable), Member = "GetCodePageFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static int internalGetCodePageFromName(string name)
		{
			throw null;
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x0001B8C0 File Offset: 0x00019AC0
		[global::Cpp2ILInjected.Token(Token = "0x6002CD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFBBB4", Offset = "0x1BFBBB4", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "GetEncoding", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Text.EncoderFallback),
			typeof(global::System.Text.DecoderFallback)
		}, ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncodingTable), Member = "internalGetCodePageFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal static int GetCodePageFromName(string name)
		{
			throw null;
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x0001B8C3 File Offset: 0x00019AC3
		[global::Cpp2ILInjected.Token(Token = "0x6002CD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFBE18", Offset = "0x1BFBE18", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "GetDataItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePageDataItem), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal static CodePageDataItem GetCodePageDataItem(int codepage)
		{
			throw null;
		}

		// Token: 0x04001511 RID: 5393
		[global::Cpp2ILInjected.Token(Token = "0x40018EE")]
		internal static InternalEncodingDataItem[] encodingDataPtr;

		// Token: 0x04001512 RID: 5394
		[global::Cpp2ILInjected.Token(Token = "0x40018EF")]
		internal static InternalCodePageDataItem[] codePageDataPtr;

		// Token: 0x04001513 RID: 5395
		[global::Cpp2ILInjected.Token(Token = "0x40018F0")]
		private static int lastEncodingItem;

		// Token: 0x04001514 RID: 5396
		[global::Cpp2ILInjected.Token(Token = "0x40018F1")]
		private static global::System.Collections.Generic.Dictionary<string, int> hashByName;

		// Token: 0x04001515 RID: 5397
		[global::Cpp2ILInjected.Token(Token = "0x40018F2")]
		private static global::System.Collections.Generic.Dictionary<int, CodePageDataItem> hashByCodePage;
	}
}
