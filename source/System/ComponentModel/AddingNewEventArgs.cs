using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000345")]
	public class AddingNewEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x60015C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3D208", Offset = "0x1E3D208", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AddingNewEventArgs()
		{
			throw null;
		}

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

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object <NewObject>k__BackingField;
	}
}
