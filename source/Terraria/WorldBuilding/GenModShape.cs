﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004C8")]
	public abstract class GenModShape : GenShape
	{
		[global::Cpp2ILInjected.Token(Token = "0x600301B")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F8610", Offset = "0x12F8610", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GenModShape(ShapeData data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40039C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected ShapeData _data;
	}
}
