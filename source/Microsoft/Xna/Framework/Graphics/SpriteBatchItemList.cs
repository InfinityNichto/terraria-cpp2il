using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000390")]
	public class SpriteBatchItemList
	{
		[global::Cpp2ILInjected.Token(Token = "0x600185A")]
		[global::Cpp2ILInjected.Address(RVA = "0xABDCAC", Offset = "0xABDCAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SpriteBatchItemList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40026A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public SpriteBatchItem First;

		[global::Cpp2ILInjected.Token(Token = "0x40026A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public SpriteBatchItem Last;
	}
}
