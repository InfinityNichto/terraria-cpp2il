using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002C6")]
	internal static class UnixIPGlobalPropertiesFactoryPal
	{
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

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000F11")]
		private static readonly bool <PlatformNeedsLibCWorkaround>k__BackingField;
	}
}
