using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	[global::Cpp2ILInjected.Token(Token = "0x200054D")]
	public class TileObjectDrawModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60032F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1331774", Offset = "0x1331774", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawYOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawXOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawFlipHorizontal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawFlipVertical", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_DrawStepDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TileObjectDrawModule(TileObjectDrawModule copyFrom = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003BF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int xOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4003BF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int yOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4003BF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool flipHorizontal;

		[global::Cpp2ILInjected.Token(Token = "0x4003BF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		public bool flipVertical;

		[global::Cpp2ILInjected.Token(Token = "0x4003BF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int stepDown;
	}
}
