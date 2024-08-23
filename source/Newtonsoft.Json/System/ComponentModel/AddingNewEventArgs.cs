using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000002 RID: 2
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public class AddingNewEventArgs
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020F0 File Offset: 0x000002F0
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000020F3 File Offset: 0x000002F3
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public object NewObject
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000001")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5AE4", Offset = "0x1CB5AE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000002")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5AEC", Offset = "0x1CB5AEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020F6 File Offset: 0x000002F6
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5AF4", Offset = "0x1CB5AF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JContainer), Member = "System.ComponentModel.IBindingList.AddNew", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AddingNewEventArgs()
		{
			throw null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020F9 File Offset: 0x000002F9
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5AFC", Offset = "0x1CB5AFC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AddingNewEventArgs(object newObject)
		{
			throw null;
		}

		// Token: 0x04000001 RID: 1
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object <NewObject>k__BackingField;
	}
}
