using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000383")]
	internal class PresentationEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x170002F6")]
		public PresentationParameters PresentationParameters
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017CB")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3B48", Offset = "0xAB3B48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017CC")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB3B50", Offset = "0xAB3B50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017CD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB3B58", Offset = "0xAB3B58", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PresentationEventArgs(PresentationParameters presentationParameters)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002623")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private PresentationParameters <PresentationParameters>k__BackingField;
	}
}
