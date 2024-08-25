using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000717")]
	public class EmptyDiagnosticsUI : INetDiagnosticsUI
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003C13")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D444", Offset = "0x148D444", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C14")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D448", Offset = "0x148D448", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CountReadMessage(int messageId, int messageLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C15")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D44C", Offset = "0x148D44C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CountSentMessage(int messageId, int messageLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C16")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D450", Offset = "0x148D450", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CountReadModuleMessage(int moduleMessageId, int messageLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C17")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D454", Offset = "0x148D454", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void CountSentModuleMessage(int moduleMessageId, int messageLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C18")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D458", Offset = "0x148D458", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003C19")]
		[global::Cpp2ILInjected.Address(RVA = "0x148D45C", Offset = "0x148D45C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_ActiveNetDiagnosticsUI", ReturnType = typeof(INetDiagnosticsUI))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EmptyDiagnosticsUI()
		{
			throw null;
		}
	}
}
