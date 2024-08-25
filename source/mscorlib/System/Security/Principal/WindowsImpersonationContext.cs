using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Principal
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200032C")]
	public class WindowsImpersonationContext : global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001B69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1F50C", Offset = "0x1B1F50C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WindowsIdentity), Member = "Impersonate", ReturnType = typeof(WindowsImpersonationContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal WindowsImpersonationContext(global::System.IntPtr token)
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FBEC", Offset = "0x1B1FBEC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FBFC", Offset = "0x1B1FBFC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Undo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FCC0", Offset = "0x1B1FCC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool CloseToken(global::System.IntPtr token);

		[global::Cpp2ILInjected.Token(Token = "0x6001B6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FBE4", Offset = "0x1B1FBE4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.IntPtr DuplicateToken(global::System.IntPtr token);

		[global::Cpp2ILInjected.Token(Token = "0x6001B6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FBE8", Offset = "0x1B1FBE8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool SetCurrentToken(global::System.IntPtr token);

		[global::Cpp2ILInjected.Token(Token = "0x6001B6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1FCBC", Offset = "0x1B1FCBC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool RevertToSelf();

		[global::Cpp2ILInjected.Token(Token = "0x4000DF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.IntPtr _token;

		[global::Cpp2ILInjected.Token(Token = "0x4000DF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool undo;
	}
}
