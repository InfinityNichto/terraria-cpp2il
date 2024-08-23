using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200010B RID: 267
	[Obsolete("This class has been deprecated. Please use WebRequest.DefaultWebProxy instead to access and set the global default proxy. Use 'null' instead of GetEmptyWebProxy. https://go.microsoft.com/fwlink/?linkid=14202")]
	[global::Cpp2ILInjected.Token(Token = "0x2000190")]
	public class GlobalProxySelection
	{
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00004865 File Offset: 0x00002A65
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00004868 File Offset: 0x00002A68
		[global::Cpp2ILInjected.Token(Token = "0x17000214")]
		public static IWebProxy Select
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C330", Offset = "0x1F0C330", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_DefaultWebProxy", ReturnType = typeof(IWebProxy))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GlobalProxySelection), Member = "GetEmptyWebProxy", ReturnType = typeof(IWebProxy))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C474", Offset = "0x1F0C474", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0000486B File Offset: 0x00002A6B
		[global::Cpp2ILInjected.Token(Token = "0x6000A47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C420", Offset = "0x1F0C420", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlobalProxySelection), Member = "get_Select", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmptyWebProxy), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IWebProxy GetEmptyWebProxy()
		{
			throw null;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0000486E File Offset: 0x00002A6E
		[global::Cpp2ILInjected.Token(Token = "0x6000A48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C51C", Offset = "0x1F0C51C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GlobalProxySelection()
		{
			throw null;
		}
	}
}
