using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001E4 RID: 484
	[global::Cpp2ILInjected.Token(Token = "0x20002C6")]
	internal static class UnixIPGlobalPropertiesFactoryPal
	{
		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00005E70 File Offset: 0x00004070
		[global::Cpp2ILInjected.Token(Token = "0x17000452")]
		private static bool PlatformNeedsLibCWorkaround
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60012CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E209B8", Offset = "0x1E209B8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00005E73 File Offset: 0x00004073
		[global::Cpp2ILInjected.Token(Token = "0x60012CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E48C", Offset = "0x1E1E48C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPGlobalPropertiesFactoryPal), Member = "Create", ReturnType = typeof(IPGlobalProperties))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static IPGlobalProperties Create()
		{
			throw null;
		}

		// Token: 0x04000B40 RID: 2880
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000F11")]
		private static readonly bool <PlatformNeedsLibCWorkaround>k__BackingField;
	}
}
