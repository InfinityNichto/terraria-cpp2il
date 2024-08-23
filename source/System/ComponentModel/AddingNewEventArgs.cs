using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000253 RID: 595
	[global::Cpp2ILInjected.Token(Token = "0x2000345")]
	public class AddingNewEventArgs : EventArgs
	{
		// Token: 0x06001385 RID: 4997 RVA: 0x000065F3 File Offset: 0x000047F3
		[global::Cpp2ILInjected.Token(Token = "0x60015C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3D208", Offset = "0x1E3D208", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AddingNewEventArgs()
		{
			throw null;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x000065F6 File Offset: 0x000047F6
		[global::Cpp2ILInjected.Token(Token = "0x60015C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3D260", Offset = "0x1E3D260", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BindingList<>), Member = "FireAddingNew", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AddingNewEventArgs(object newObject)
		{
			throw null;
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x000065F9 File Offset: 0x000047F9
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x000065FC File Offset: 0x000047FC
		[global::Cpp2ILInjected.Token(Token = "0x170004F5")]
		public object NewObject
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3D2CC", Offset = "0x1E3D2CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3D2D4", Offset = "0x1E3D2D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000DB0 RID: 3504
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object <NewObject>k__BackingField;
	}
}
