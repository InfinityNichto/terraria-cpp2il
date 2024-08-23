using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200012B RID: 299
	[global::Cpp2ILInjected.Token(Token = "0x20001B2")]
	internal class WebRequestPrefixElement
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0000494F File Offset: 0x00002B4F
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00004952 File Offset: 0x00002B52
		[global::Cpp2ILInjected.Token(Token = "0x17000229")]
		public IWebRequestCreate Creator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0F7B8", Offset = "0x1F0F7B8", Length = "0x1FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(bool)
			}, ReturnType = typeof(WebRequest))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(BindingFlags),
				typeof(Binder),
				typeof(object[]),
				typeof(CultureInfo)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000AA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0F9B4", Offset = "0x1F0F9B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00004955 File Offset: 0x00002B55
		[global::Cpp2ILInjected.Token(Token = "0x6000AA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0F9BC", Offset = "0x1F0F9BC", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public WebRequestPrefixElement(string P, Type creatorType)
		{
			throw null;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00004958 File Offset: 0x00002B58
		[global::Cpp2ILInjected.Token(Token = "0x6000AA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0FB30", Offset = "0x1F0FB30", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public WebRequestPrefixElement(string P, IWebRequestCreate C)
		{
			throw null;
		}

		// Token: 0x040006F2 RID: 1778
		[global::Cpp2ILInjected.Token(Token = "0x400090B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Prefix;

		// Token: 0x040006F3 RID: 1779
		[global::Cpp2ILInjected.Token(Token = "0x400090C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal IWebRequestCreate creator;

		// Token: 0x040006F4 RID: 1780
		[global::Cpp2ILInjected.Token(Token = "0x400090D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal Type creatorType;
	}
}
