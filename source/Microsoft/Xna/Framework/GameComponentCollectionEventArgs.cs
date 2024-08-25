using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework
{
	[global::Cpp2ILInjected.Token(Token = "0x200033B")]
	public class GameComponentCollectionEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x60014E5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA97160", Offset = "0xA97160", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameComponentCollection), Member = "ClearItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameComponentCollection), Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IGameComponent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameComponentCollection), Member = "RemoveItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public GameComponentCollectionEventArgs(IGameComponent gameComponent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000219")]
		public IGameComponent GameComponent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014E6")]
			[global::Cpp2ILInjected.Address(RVA = "0xA971CC", Offset = "0xA971CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40022C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IGameComponent _gameComponent;
	}
}
