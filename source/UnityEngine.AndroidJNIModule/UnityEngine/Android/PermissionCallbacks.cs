using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Android
{
	// Token: 0x02000015 RID: 21
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	public class PermissionCallbacks : AndroidJavaProxy
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000184 RID: 388 RVA: 0x00002308 File Offset: 0x00000508
		// (remove) Token: 0x06000185 RID: 389 RVA: 0x0000230B File Offset: 0x0000050B
		[global::Cpp2ILInjected.Token(Token = "0x14000001")]
		public event Action<string> PermissionGranted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600018A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F66330", Offset = "0x1F66330", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600018B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F663E0", Offset = "0x1F663E0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000186 RID: 390 RVA: 0x0000230E File Offset: 0x0000050E
		// (remove) Token: 0x06000187 RID: 391 RVA: 0x00002311 File Offset: 0x00000511
		[global::Cpp2ILInjected.Token(Token = "0x14000002")]
		public event Action<string> PermissionDenied
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600018C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F66490", Offset = "0x1F66490", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600018D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F66540", Offset = "0x1F66540", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000188 RID: 392 RVA: 0x00002314 File Offset: 0x00000514
		// (remove) Token: 0x06000189 RID: 393 RVA: 0x00002317 File Offset: 0x00000517
		[global::Cpp2ILInjected.Token(Token = "0x14000003")]
		public event Action<string> PermissionDeniedAndDontAskAgain
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600018E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F665F0", Offset = "0x1F665F0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600018F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F666A0", Offset = "0x1F666A0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000231A File Offset: 0x0000051A
		[global::Cpp2ILInjected.Token(Token = "0x6000190")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F66750", Offset = "0x1F66750", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaProxy), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public PermissionCallbacks()
		{
			throw null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000231D File Offset: 0x0000051D
		[Preserve]
		[global::Cpp2ILInjected.Token(Token = "0x6000191")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F667BC", Offset = "0x1F667BC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void onPermissionGranted(string permissionName)
		{
			throw null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002320 File Offset: 0x00000520
		[Preserve]
		[global::Cpp2ILInjected.Token(Token = "0x6000192")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F667D8", Offset = "0x1F667D8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void onPermissionDenied(string permissionName)
		{
			throw null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002323 File Offset: 0x00000523
		[Preserve]
		[global::Cpp2ILInjected.Token(Token = "0x6000193")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F667F4", Offset = "0x1F667F4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void onPermissionDeniedAndDontAskAgain(string permissionName)
		{
			throw null;
		}

		// Token: 0x04000041 RID: 65
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000048")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Action<string> PermissionGranted;

		// Token: 0x04000042 RID: 66
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Action<string> PermissionDenied;

		// Token: 0x04000043 RID: 67
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Action<string> PermissionDeniedAndDontAskAgain;
	}
}
