using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001FE RID: 510
	[global::Cpp2ILInjected.Token(Token = "0x2000290")]
	internal static class EncodingHelper
	{
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00017F3F File Offset: 0x0001613F
		[global::Cpp2ILInjected.Token(Token = "0x1700024B")]
		internal static Encoding UTF8Unmarked
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE9B54", Offset = "0x1AE9B54", Length = "0x1DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EncodingHelper), Member = "GetDefaultEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamWriter), Member = "get_UTF8NoBOM", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060014B8 RID: 5304
		[global::Cpp2ILInjected.Token(Token = "0x60016B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9D30", Offset = "0x1AE9D30", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern string InternalCodePage(ref int code_page);

		// Token: 0x060014B9 RID: 5305 RVA: 0x00017F42 File Offset: 0x00016142
		[global::Cpp2ILInjected.Token(Token = "0x60016B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE6D4C", Offset = "0x1AE6D4C", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "CreateDefaultEncoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncodingHelper), Member = "get_UTF8Unmarked", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal static Encoding GetDefaultEncoding()
		{
			throw null;
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00017F45 File Offset: 0x00016145
		[global::Cpp2ILInjected.Token(Token = "0x60016B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE51AC", Offset = "0x1AE51AC", Length = "0x6F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 68)]
		internal static object InvokeI18N(string name, params object[] args)
		{
			throw null;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00017F48 File Offset: 0x00016148
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE9D34", Offset = "0x1AE9D34", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static EncodingHelper()
		{
			throw null;
		}

		// Token: 0x040008FF RID: 2303
		[global::Cpp2ILInjected.Token(Token = "0x4000B92")]
		private static Encoding utf8EncodingWithoutMarkers;

		// Token: 0x04000900 RID: 2304
		[global::Cpp2ILInjected.Token(Token = "0x4000B93")]
		private static readonly object lockobj;

		// Token: 0x04000901 RID: 2305
		[global::Cpp2ILInjected.Token(Token = "0x4000B94")]
		private static global::System.Reflection.Assembly i18nAssembly;

		// Token: 0x04000902 RID: 2306
		[global::Cpp2ILInjected.Token(Token = "0x4000B95")]
		private static bool i18nDisabled;
	}
}
