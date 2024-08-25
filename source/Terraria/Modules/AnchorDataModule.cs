using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria.Modules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000546")]
	public class AnchorDataModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60032E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x132EFD8", Offset = "0x132EFD8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AnchorDataModule(AnchorDataModule copyFrom = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003BD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public AnchorData top;

		[global::Cpp2ILInjected.Token(Token = "0x4003BD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public AnchorData bottom;

		[global::Cpp2ILInjected.Token(Token = "0x4003BD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public AnchorData left;

		[global::Cpp2ILInjected.Token(Token = "0x4003BDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public AnchorData right;

		[global::Cpp2ILInjected.Token(Token = "0x4003BDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool wall;
	}
}
